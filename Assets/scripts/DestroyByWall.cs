﻿using UnityEngine;
using System.Collections;

public class DestroyByWall : MonoBehaviour
{
    public bool enableScript;

    private GameController gameController;

	// Use this for initialization
	void Start ()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if (enableScript)
        {
            if (collision.gameObject.tag == "Ball")
            {
                Destroy(collision.gameObject);
                gameController.RemoveBall();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
