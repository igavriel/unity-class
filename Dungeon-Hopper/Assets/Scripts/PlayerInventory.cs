using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    // Counter of all items - score - private property for debug
    public int Score { get; private set; }

    // an event for collected item
    public UnityEvent<PlayerInventory> OnItemCollected;

    public void CollectItem(int value)
    {
        Score += value;
        OnItemCollected.Invoke(this);
    }
}
