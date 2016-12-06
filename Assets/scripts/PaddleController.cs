using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("PowerUp"))
        {
            if (other.name.StartsWith("MultiplyPP"))
            {
                foreach (var MPUS in GameObject.FindGameObjectsWithTag("Ball"))
                {
                    MPUS.GetComponent<MultiplyPowerUpScript>().enabled = true;
                }
                Destroy(other.gameObject);
            }
        }
    }
}
