using UnityEngine;

public class ObjectCollector : MonoBehaviour
{
    public int objectValue = 1;
    public float destroyDelay = 0.1f; // Time delay before destroying the chest

    private AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        if (playerInventory != null)
        {
            Collect(playerInventory);
        }
    }

    private void Collect(PlayerInventory inventory)
    {
        Debug.Log("Object collected!");

        if (sound)
        {   // You can add effects here, like sound or particles
            AudioSource.PlayClipAtPoint(sound.clip, transform.position);
        }

        inventory.CollectItem(objectValue);

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.CollectItem();

        // SpawnCollectionParticles();

        // Destroy the object
        Destroy(gameObject, destroyDelay);
    }
}
