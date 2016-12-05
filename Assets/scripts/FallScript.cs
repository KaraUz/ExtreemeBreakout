using UnityEngine;
using System.Collections;

public class FallScript : MonoBehaviour {
    private Rigidbody _rb;
    public float fallSpeed = 10;
    public Vector3 eulerAngleVelocity;
    // Use this for initialization
    void Start () {
        _rb = transform.GetComponent<Rigidbody>();
        _rb.velocity = new Vector3(0, 0, -fallSpeed);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
        _rb.MoveRotation(_rb.rotation * deltaRotation);
    }
}
