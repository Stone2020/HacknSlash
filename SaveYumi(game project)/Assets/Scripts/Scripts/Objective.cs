﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public GameObject prefab;
    public Transform objective;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 shootDirection = new Vector2(objective.position.x - transform.position.x, objective.position.y - transform.position.y);
    }
}
