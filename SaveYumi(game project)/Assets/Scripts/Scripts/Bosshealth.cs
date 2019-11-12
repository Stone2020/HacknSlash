using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bosshealth : MonoBehaviour
{
    public int enemyHealth = 2;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "projectile")
            enemyHealth--;

        if (enemyHealth < 1)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Level 3");
            GameObject.FindGameObjectWithTag("Player").GetComponent<PointsCollection>().IncreasePoints();
        }
    }
}
