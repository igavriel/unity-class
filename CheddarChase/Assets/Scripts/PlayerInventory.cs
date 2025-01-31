using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int score = 0;
    public int debugLastValue = 0;
    public int debugHighScore = 0;

    // an event for collected item
    public UnityEvent<PlayerInventory> OnItemCollected;

    public void CollectItem(int value)
    {
        ScoreManager.AddScore(value);
        score += value;

        debugLastValue = value;
        debugHighScore = ScoreManager.HighScore;
        OnItemCollected.Invoke(this);
    }
}
