using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLook : MonoBehaviour

{
    public Transform player;
    public float chaseSpeed = 2.0f;
    public float paceSpeed = 1.0f;
    public float chaseTriggerDistance = 5.0f;
    Vector3 startPosition;
    bool home = true;
    public Vector3 paceDirection;
    public float paceDistance = 3.0f;

    void Start()
    {
        startPosition = transform.position;
    }







    // Update is called once per frame
    void Update()
    {
        Vector2 chaseDirection = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        if (chaseDirection.magnitude <= chaseTriggerDistance)
        {
            Chaseplayer();
        }
        else if (!home)
        {
            GoHome();
        }
        else
        {
            Pace();
        }
    }

    void Chaseplayer()
    {
        home = false;
        Vector2 chaseDirection = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        if (chaseDirection.magnitude <= chaseTriggerDistance);
        chaseDirection.Normalize();
        GetComponent<Rigidbody2D>().velocity = chaseDirection * chaseSpeed;
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.right = player.position - transform.position;
        transform.up = chaseDirection;


    }
    void GoHome()
    {
        Vector2 homeDirection = new Vector2(startPosition.x - transform.position.x, startPosition.y - transform.position.y);
        if (homeDirection.magnitude < 1)
        {
            transform.position = startPosition;
            home = true;
        }
        else
        {
            homeDirection.Normalize();
            transform.up = homeDirection;
            GetComponent<Rigidbody2D>().velocity = homeDirection * paceSpeed;
        }
    }
    void Pace()
    {
        Vector3 displacement = transform.position - startPosition;
        if(displacement.magnitude >= paceDistance)
        {
            paceDirection = -displacement;
        }
        paceDirection.Normalize();
        transform.up = paceDirection;
        GetComponent<Rigidbody2D>().velocity = paceDirection * paceSpeed;
    }

}
