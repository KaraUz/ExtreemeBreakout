using UnityEngine;
using System.Collections;

public class GameControllerScript : MonoBehaviour {
    public int _score;
    public GUIText scoreText;
    // Use this for initialization
    void Start () {
        _score = 0;
        UpdateScore();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddScore(int score)
    {
        _score += score;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + _score;
    }
}
