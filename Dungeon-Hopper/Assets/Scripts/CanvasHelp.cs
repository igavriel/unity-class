using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasHelp : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.UnloadSceneAsync("HelpScene");
        }
    }
}
