using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gotobed : MonoBehaviour
{
 
    void Start()
    {
        
    }


    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
                GetComponentInChildren<Canvas>().enabled = true;

            }
            else
            {
                Time.timeScale = 1;
                GetComponentInChildren<Canvas>().enabled = false;
            }
           
        }
    }   
    public void No()
    {
        Time.timeScale = 1;
        GetComponentInChildren<Canvas>().enabled = false;
    }
    public void Yes()
    {
     
        Time.timeScale = 1;
        SceneManager.LoadScene("Good Ending");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

