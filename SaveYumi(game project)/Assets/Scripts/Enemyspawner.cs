using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    public float enemystart = 10;
    public GameObject Enemy;
    float randX;
    Vector2 spawnLOC;
    public float rateOFSpawn = 2f;
    float nextEnemy = 0.0f;

    void Update()
    {
        if (Time.time > nextEnemy && enemystart > 0)
        {
            nextEnemy = Time.time + rateOFSpawn;
            {
                enemystart--;
            }
            randX = Random.Range (-8.4f,8.4f);
            spawnLOC = new Vector3 (randX, transform.position.y, transform.position.x);
            Instantiate(Enemy, spawnLOC, Quaternion.identity);
            if (enemystart < 1)
            {
                Destroy(gameObject);
            }
              
        }
    }







}


