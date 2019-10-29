using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   public void Retry()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Retry1()
    {
        SceneManager.LoadScene("Level 2");
    
    }
    public void Retry3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void Retry4()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
