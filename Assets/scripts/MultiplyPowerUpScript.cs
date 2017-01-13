using UnityEngine;
using System.Collections;

public class MultiplyPowerUpScript : MonoBehaviour {

    private Rigidbody _rb;

    void OnEnable()
    {
        print("script was enabled");
        var prefab = (GameObject)Resources.Load("Ball", typeof(GameObject));
        if (_rb==null) _rb = gameObject.GetComponent<Rigidbody>();
        var newBall = (GameObject) Instantiate(prefab, transform.position, Quaternion.identity);
        newBall.GetComponent<Rigidbody>().velocity = new Vector3(-_rb.velocity.x, -_rb.velocity.y, -_rb.velocity.z);
        GameObject.Find("GameController").GetComponent<GameController>().AddBall();
        enabled = false;
    }
}
