﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownL : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody objectRb;
    float zDestroy = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectRb.AddForce(Vector3.forward * -speed);

        if (transform.position.z < zDestroy)
            Destroy(gameObject);
    }
}
