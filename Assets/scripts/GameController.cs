using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GUIText scoreText;
    public GUIText highScoreText;
    public GUIText gameOverText;
    public Text newHighScoreNameText;
    public Canvas newHighScoreCanvas;
    public string highScoreSceneName = "HighScore_scene";

    private int numberOfBalls = 1;
    private int highScore = 0;
    private bool gameOver;
    private int score;
    public string SceneName;

    void Start()
    {
        gameOver = false;
        gameOverText.text = "";
        score = 0;
        highScore = PlayerPrefs.GetInt("Score1");
        UpdateHighScore();
        UpdateScore();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("scene " + SceneName + "loading");
            SceneManager.LoadScene(SceneName);
        }
    }

    public void AddScore(int score)
    {
        this.score += score;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    void UpdateHighScore()
    {
        highScoreText.text = "Highscore: " + highScore;
    }

    public void AddBall()
    {
        numberOfBalls++;
    }

    public void RemoveBall()
    {
        numberOfBalls--;
        CheckGameOver();
    }

    private void CheckGameOver()
    {
        if (numberOfBalls == 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        if (score > highScore)
        {
            newHighScoreCanvas.gameObject.SetActive(true);
            gameOverText.text = "Game Over!\nNEW HIGHSCORE!!!";
            gameOver = true;
            
        }
        else
        {
            newHighScoreCanvas.gameObject.SetActive(true);
            gameOverText.text = "Game Over!";
            gameOver = true;
        }
    }

    public void HandleNewHighScore()
    {
        for (int i = 1; i <= 11; i++)
        {         
            if (PlayerPrefs.GetString("Name" + i) == null || PlayerPrefs.GetString("Name" + i) == "")
            {
                PlayerPrefs.SetString("Name" + i, newHighScoreNameText.text);
                PlayerPrefs.SetInt("Score" + i, score);
                break;
            }
            else if(score>PlayerPrefs.GetInt("Score" + i))
            {
                PlayerPrefs.SetString("Name" + i, newHighScoreNameText.text);
                PlayerPrefs.SetInt("Score" + i, score);
                break;
            }
        }
        Debug.Log("scene " + highScoreSceneName + "loading");
        SceneManager.LoadScene(highScoreSceneName);
    }
}
