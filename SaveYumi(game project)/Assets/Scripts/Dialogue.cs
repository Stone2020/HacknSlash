using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] dialogue;
    private int index;
    public float scrollSpeed;
    public GameObject nextButton;

    void start()
    {
        StartCoroutine(Type());
    }
     void Update()
    {
        if(textDisplay.text == dialogue[index])
        {
            nextButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach(char letter in dialogue[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(scrollSpeed);
        }
    }
    public void Nextline()
    {
        nextButton.SetActive(false);
        if (index < dialogue.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            nextButton.SetActive(false);
        }
    }
   

}
