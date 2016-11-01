using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, -40);
    }

    // Update is called once per frame
    void Update()
    {
        //if(rb.velocity.z==0)rb.AddForce(new Vector3(0,0,-20));
        rb.velocity = rb.velocity.normalized * 40; // needed because we are loosing speed
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Velocity: " + rb.velocity);
        //rb.AddForce(new Vector3(0, 1000, 0));
    }
}
