using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text timerText;
    private float timeRemaining = 60f; // Starting time in seconds
    private bool isGameOver = false;

    void Update()
    {
        if (!isGameOver)
        {
            timeRemaining -= Time.deltaTime;
            UpdateCounterDisplay();

            if (timeRemaining <= 0)
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

    public void CollectItem()
    {
        timeRemaining += 3f; // Increase time by 3 seconds
    }

    void GameOver()
    {
        isGameOver = true;
        //SceneManager.LoadScene("GameOverScene"); // Load your game over scene
    }
}
