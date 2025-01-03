using UnityEngine;
using TMPro;

public class CanvasControl : MonoBehaviour
{
    public GameObject welcomeScreen;
    public TMP_Text scoreText;
    public TMP_Text timerText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            welcomeScreen.SetActive(false);
            scoreText.enabled = true;
            timerText.enabled = true;
        }
    }

    public void UpdateScoreText(PlayerInventory inventory)
    {
        scoreText.SetText($"Score: {inventory.Score}");
    }
}
