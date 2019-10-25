using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject prefab;
    public float shootSpeed = 10.0f;
    public float bulletLifetime = 1.0f;
    public float shootDelay = 7.0f;
    float timer = 0;
    public float shootTriggerDistance = 10.0f;

    public Transform player;




    private void Update()
    {
        timer += Time.deltaTime;
        Vector2 shootDirection = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        if (timer > shootDelay && shootDirection.magnitude < shootTriggerDistance)
        {
            timer = 0;

            GameObject Enemybullet = Instantiate(prefab, transform.position, Quaternion.identity);
            shootDirection.Normalize();
            Enemybullet.GetComponent<Rigidbody2D>().velocity = shootDirection * shootSpeed;
            Destroy(Enemybullet, bulletLifetime);
        }









        
    }

}
