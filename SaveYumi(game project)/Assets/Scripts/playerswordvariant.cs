using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerswordvariant: MonoBehaviour
{
    public GameObject prefab;
   
    public float swordswing = 1.0f;
    public float sworddelay = 0.01f;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 velocity = new Vector2(x, y);

        timer += Time.deltaTime;
        if (Input.GetButton("Fire1") && timer > sworddelay)
        {
            timer = 0;
            Vector3 swordposition = transform.position;
            swordposition.x += x;
            swordposition.y += y;
            GameObject sword = Instantiate(prefab, swordposition , Quaternion.identity);
            sword.transform.right = swordposition;
            sword.transform.parent = gameObject.transform;
            Destroy(sword, sworddelay);


            
        }
    }
}
