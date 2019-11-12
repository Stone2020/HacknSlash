using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHP : MonoBehaviour
{
    public int health = 20;
    public Text healthText;
    public Slider healthSlider;
    public Text livesText;
    public int Lives;
   

    private void Start()
    {
        healthText.text = "HP: " + health;
        healthSlider.maxValue = health;
        healthSlider.value = health;
        Lives = PlayerPrefs.GetInt("Lives");
        livesText.text = "Lives: " + Lives;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            healthText.text = "HP: " + health;
            healthSlider.value = health;
            if (health < 1)
            {
                if(Lives > 0)
                {
                
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    PlayerPrefs.SetInt("Lives", Lives - 1);

                }
                else
                {
                    
                    SceneManager.LoadScene("Game Over");
                }
                
            }

        }
        if (collision.gameObject.tag == "Biggun")
        {
            health -= 5;
            healthText.text = "HP: " + health;
            healthSlider.value = health;
            if (health < 1)
            {
                if (Lives > 0)
                {

                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    PlayerPrefs.SetInt("Lives", Lives - 1);

                }
                else
                {

                    SceneManager.LoadScene("Game Over");
                }

            }

        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            healthText.text = "HP: " + health;
            healthSlider.value = health;
            if (health < 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if (collision.gameObject.tag == "health" && health < 20)
        {
            health++;
            Destroy(collision.gameObject);
            healthText.text = "HP: " + health;
            healthSlider.value = health;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PointsCollection>().IncreasePoints();
        }

    }

    
}

