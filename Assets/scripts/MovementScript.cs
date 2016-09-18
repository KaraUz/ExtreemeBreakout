using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
    private Rigidbody rb;
    public float Speed = 10;
	// Use this for initialization
	void Start () {
        rb = transform.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float direction = Input.GetAxis("Horizontal");
        rb.MovePosition(transform.position + transform.right *direction * Speed* Time.deltaTime);
    }
}
