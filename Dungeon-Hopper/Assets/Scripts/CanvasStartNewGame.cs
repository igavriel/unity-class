using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasStartNewGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("HelpScene", LoadSceneMode.Additive);
        }
    }
}
