using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CanvasGameOver : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    void Start()
    {
        scoreText.SetText($"Score: {ScoreManager.Score}");
        highScoreText.SetText($"High Score: {ScoreManager.HighScore}");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("2.GameScene");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("4.HelpScene", LoadSceneMode.Additive);
        }
    }
}
