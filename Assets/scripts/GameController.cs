using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GUIText scoreText;
    public GUIText highScoreText;
    public GUIText gameOverText;

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
            PlayerPrefs.SetInt("Score1", score);
            gameOverText.text = "Game Over!\nNEW HIGHSCORE!!!";
            gameOver = true;
        }
        else
        {
            gameOverText.text = "Game Over!";
            gameOver = true;
        }
    }
}
