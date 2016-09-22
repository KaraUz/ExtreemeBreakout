using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, 0, -2000));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Velocity: " + rb.velocity);
        


        //rb.AddForce(new Vector3(0, 1000, 0));
    }
}
