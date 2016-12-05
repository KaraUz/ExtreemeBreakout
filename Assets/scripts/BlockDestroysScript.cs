using UnityEngine;
using System.Collections;

public class BlockDestroysScript : MonoBehaviour
{
    
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnCollisionExit(Collision col)
    {
        
        if (col.collider.tag.Equals("Ball"))
        {
            Destroy(gameObject);
        }
    }
}
