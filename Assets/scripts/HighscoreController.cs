using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class HighscoreController : MonoBehaviour {
    private Text text;

    public string SceneName;

    // Use this for initialization
    void Start () {
        text = gameObject.GetComponent<Text>();
        text.text = "";
        for (int i = 1; i <= 11; i++)
        {
            text.text += PlayerPrefs.GetString("Name" + i) == null || PlayerPrefs.GetString("Name" + i) == ""?"XXX": PlayerPrefs.GetString("Name" + i);
            text.text += ": ";
            text.text += PlayerPrefs.GetInt("Score" + i);
            text.text += "\n";
        }
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("scene " + SceneName + "loading");
            SceneManager.LoadScene(SceneName);
        }
        if (Input.GetKey(KeyCode.X))
        {
            Debug.Log("Resetting player prefs");
            PlayerPrefs.DeleteAll();
            Start();
        }
    }
}
