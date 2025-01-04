using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasHelp : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.UnloadSceneAsync("4.HelpScene");
        }
    }
}
