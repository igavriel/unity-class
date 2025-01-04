using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CanvasGameControl : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text timerText;
    private bool audioSound = true;

    void Start()
    {
        scoreText.enabled = true;
        timerText.enabled = true;
        ScoreManager.ResetScore();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("HelpScene", LoadSceneMode.Additive);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            audioSound = !audioSound;
            AudioListener.volume = audioSound ? 1f : 0f;
        }
    }
}
