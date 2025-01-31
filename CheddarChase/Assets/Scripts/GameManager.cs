using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text timerText;
    public float timeRemaining = 60f; // Starting time in seconds
    private bool isGameOver = false;

    void Update()
    {
        // update time only if not game over and not paused
        if (!isGameOver && !ScoreManager.PauseGame)
        {
            timeRemaining -= Time.deltaTime;

            if (timeRemaining >= 0)
            {
                UpdateCounterDisplay();
            }
            else
            {
                GameOver();
            }
        }
    }

    void UpdateCounterDisplay()
    {
        int seconds = Mathf.FloorToInt(timeRemaining);
        timerText.SetText($"Time: {seconds} Sec.");
    }

    public void UpdateScoreText(PlayerInventory inventory)
    {
        scoreText.SetText($"Score: {inventory.score}");
    }

    public void CollectItem()
    {
        timeRemaining += 3f; // Increase time by 3 seconds
    }

    void GameOver()
    {
        isGameOver = true;
        SceneManager.LoadScene("3.GameOverScene"); // Load your game over scene
    }
}
