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
            pointCount += 50;
            coinText.text = "Points: " + pointCount;
            Destroy(collision.gameObject);
           

        }
        

    }
    public void IncreasePoints()
    {
        pointCount += 100;
        coinText.text = "Points: " + pointCount;
    }

}
