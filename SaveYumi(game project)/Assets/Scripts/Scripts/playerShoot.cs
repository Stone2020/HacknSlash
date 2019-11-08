using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerShoot : MonoBehaviour
{
    public GameObject prefab;
    public float shootSpeed = 10.0f;
    public float bulletLifetime = 1.0f;
    public float shootDelay = 0.5f;
    float timer = 0;
    public float ammo = 10;
    public Text ammotext;
    // Start is called before the first frame update
    private void Start()
    {
        ammotext.text = "ammo: " + ammo;
        
    }

    // Update is called once per frame
    void Update()
    {
        


        timer += Time.deltaTime;
        if (Input.GetButton("Fire2") && timer > shootDelay && ammo > 0)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            //get mouse position in x,y pixels on the screen
            Vector3 mousePosition = Input.mousePosition;
            Debug.Log("Mouse position 1: " + mousePosition);
            //convert x,y pixels to game world position
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Debug.Log("Mouse position 2: " + mousePosition);
            Vector2 shootDirection = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
            shootDirection.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * shootSpeed;
            Destroy(bullet, bulletLifetime);
            ammo--;
            ammotext.text = "ammo: " + ammo;
            
            

        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ammo" && ammo < 10)
        {
            ammo++;
            ammotext.text = "ammo: " + ammo;
            Destroy(collision.gameObject);
        }
    }

}

