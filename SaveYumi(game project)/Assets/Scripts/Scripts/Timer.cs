using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Timer : MonoBehaviour
    
{
    float timer = 60.0f;
    public Text timerText;
   

    // Update is called once per frame
    private void Update()
    {
        
        if (timer < 0.0f)
        {
            SceneManager.LoadScene("GameOver");
            timerText.text = "Timer: ";
        }
    }
}
