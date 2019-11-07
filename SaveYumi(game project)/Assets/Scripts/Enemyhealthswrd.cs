using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhealthswrd : MonoBehaviour
{
    public int enemyHealth = 2;
    



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "sword")
        {
            enemyHealth--;
        }


        if (enemyHealth < 1)
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("Player").GetComponent<PointsCollection>().IncreasePoints();
        }
    }
}
            
    