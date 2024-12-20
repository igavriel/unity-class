using UnityEngine;
using TMPro;

public class CanvasControl : MonoBehaviour
{
    public static CanvasControl Instance;

    public GameObject title;
    public TMP_Text coinScore;
    public TMP_Text chestScore;

    private bool displayHelp = true;
    private int coinCount = 0;
    private int chestCount = 0;

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
            displayHelp = !displayHelp;
            title.SetActive(displayHelp);
        }
    }

    public void CollectCoin()
    {
        ++coinCount;
        Debug.Log($"Coins collected: {coinCount}");
        coinScore.SetText($"Coins: {coinCount}");
    }

    public void CollectChest()
    {
        ++chestCount;
        Debug.Log($"Chests collected: {chestCount}");
        chestScore.SetText($"Chest: {chestCount}");
    }

    public int GetCoinScore()
    {
        return coinCount;
    }

    public int GetChestScore()
    {
        return chestCount;
    }
}
