using UnityEngine;
using TMPro;

public class CanvasControl : MonoBehaviour
{
    public static CanvasControl Instance;

    public GameObject title;
    public GameObject image;
    public TMP_Text carrotScore;
    public TMP_Text pepperScore;

    private int carrotCount = 0;
    private int pepperCount = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            title.SetActive(false);
            image.SetActive(false);
            carrotScore.enabled = true;
            pepperScore.enabled = true;
        }
    }

    public void CollectCarrot()
    {
        ++carrotCount;
        Debug.Log($"Carrot collected: {carrotCount}");
        carrotScore.SetText($"Carrot(s): {carrotCount}");
    }

    public void CollectPepper()
    {
        ++pepperCount;
        Debug.Log($"Pepper collected: {pepperCount}");
        pepperScore.SetText($"Pepper(s): {pepperCount}");
    }
}
