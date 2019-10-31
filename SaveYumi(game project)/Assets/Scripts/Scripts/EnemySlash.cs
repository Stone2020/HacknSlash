using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlash : MonoBehaviour
{
    public GameObject prefab;
    public float slashSpeed = 10.0f;
    public float swordLifetime = 0.01f;
    public float swordDelay = 7.0f;
    float timer = 0;
    public float shootTriggerDistance = 1.0f;

    public Transform player;




    private void Update()
    {
        timer += Time.deltaTime;
        Vector2 shootDirection = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        if (timer > swordDelay && shootDirection.magnitude < shootTriggerDistance)
        {
            timer = 0;

            GameObject Enemybullet = Instantiate(prefab, transform.position, Quaternion.identity);
            shootDirection.Normalize();
            Destroy(Enemybullet, swordLifetime);
            
        }









        
    }

}
