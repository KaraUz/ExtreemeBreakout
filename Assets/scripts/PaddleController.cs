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
                int numberOfBalls = GameObject.Find("GameController").GetComponent<GameController>().GetNumberOfBalls();
                foreach (var MPUS in GameObject.FindGameObjectsWithTag("Ball"))
                {
                    if (numberOfBalls <= 3)
                        MPUS.GetComponent<MultiplyPowerUpScript>().enabled = true;
                    else if (numberOfBalls <= 10 )
                    {
                        if (Random.Range(1, 10) > 3)
                            MPUS.GetComponent<MultiplyPowerUpScript>().enabled = true;
                    }
                    else if (Random.Range(1, 10) > 7)
                            MPUS.GetComponent<MultiplyPowerUpScript>().enabled = true;
                }
                Destroy(other.gameObject);
            }
        }
    }
}
