using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highscoreText;
    public TMP_Text timerText;
    public TMP_Text titleText;

    public string gameSceneName;

    public GameObject titleObject;

    public float timeRemaining = 60f; // Starting time in seconds
    private bool isGameOver = false;
    private float timerLimit;

    void Start()
    {
        timerLimit = timeRemaining;
        Debug.Log($"Timer remaining {timeRemaining} limit {timerLimit}");
    }

    void Update()
    {
        // update time only if not game over and not paused
        if (!isGameOver && !ScoreManager.PauseGame)
        {
            timeRemaining -= Time.deltaTime;

            if (timeRemaining >= 0)
            {
                UpdateCounterDisplay();
                UpdateScoreDisplay();
                titleObject.SetActive(false);
            }
            else
            {
                GameOver();
            }
        }
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                StartGame();
                //SceneManager.LoadScene(gameSceneName);
            }
        }
    }

    void UpdateCounterDisplay()
    {
        int seconds = Mathf.FloorToInt(timeRemaining);
        timerText.SetText($"Time: {seconds} Sec.");
    }

    public void UpdateScoreDisplay()
    {
        UpdateScoreText(ScoreManager.Score);
        UpdateHighScoreText(ScoreManager.HighScore);
    }

    public void UpdateScoreText(int value)
    {
        scoreText.SetText($"Score: {value}");
    }

    public void UpdateHighScoreText(int value)
    {
        highscoreText.SetText($"Hi.Score: {value}");
    }

    public void CollectItem()
    {
        timeRemaining += 3f; // Increase time by 3 seconds
    }

    void GameOver()
    {
        isGameOver = true;
        titleText.SetText("Game Over");
        titleObject.SetActive(true);
        //        SceneManager.LoadScene("3.GameOverScene"); // Load your game over scene
    }

    void StartGame()
    {
        isGameOver = false;
        titleObject.SetActive(false);
        timeRemaining = timerLimit;
        ScoreManager.ResetScore();

        SceneManager.LoadScene(gameSceneName);
    }
}
