﻿using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    public int initialForce;

    private Rigidbody rb;
    private bool isFree = false;

    // Use this for initialization
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!isFree && Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Ball is free");
            isFree = true;
            transform.parent = null;
            rb.velocity = new Vector3(0, 0, initialForce);
            rb.isKinematic = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isFree)
            rb.velocity = rb.velocity.normalized * initialForce; // needed because we are loosing speed
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Velocity: " + rb.velocity);
    }
}
