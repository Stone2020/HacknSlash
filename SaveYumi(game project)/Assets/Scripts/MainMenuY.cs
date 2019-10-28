using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuY : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Level 1");

    }
    public void LoadLS()
    {
        SceneManager.LoadScene("Level Select");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
