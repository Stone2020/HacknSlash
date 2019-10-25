using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointsCollection : MonoBehaviour
{
    public int pointCount = 0;
    public Text coinText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "plus")
        {
            pointCount++;
            coinText.text = "Points: " + pointCount;
            Destroy(collision.gameObject);
            if (pointCount > 24)
            {
                SceneManager.LoadScene("Win2");
            }

        }
        if (collision.gameObject.tag == "minus")
        {
            pointCount--;
            Destroy(collision.gameObject);
            if (pointCount < -10)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }

}
