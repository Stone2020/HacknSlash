using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int Lives = 5;


     public void LoadGame()
    {
        SceneManager.LoadScene("Level 1");
        PlayerPrefs.SetInt("Lives", 5);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    }
