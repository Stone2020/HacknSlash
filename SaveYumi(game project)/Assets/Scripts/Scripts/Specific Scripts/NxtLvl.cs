using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NxtLvl : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Level 2");
    }
}
