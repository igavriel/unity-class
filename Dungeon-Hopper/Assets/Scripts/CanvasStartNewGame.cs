using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasStartNewGame : MonoBehaviour
{
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
