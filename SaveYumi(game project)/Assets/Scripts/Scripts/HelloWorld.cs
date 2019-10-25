using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        int hp = 100;
        float gravity = -0.2f;
        bool startQuest = true;
        string name = "Straw";
        Debug.Log(name);
        hp++;
        hp = hp + 1;
        hp = hp * 2;
        hp = hp / 3;
        // what is the vaulue of hp?
        Debug.Log(hp);
        Vector3 posistion = new Vector3();
        Debug.Log(posistion.x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
