using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float destroyDelay = 1f; // Time delay before destroying the chest

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CollectCoin();
        }
    }

    private void CollectCoin()
    {
        // Add your coin collection logic here
        Debug.Log("Coin collected!");

        // You can add effects here, like sound or particles
        // PlayCollectionSound();
        // SpawnCollectionParticles();

        // Destroy the coin
        Destroy(gameObject, destroyDelay);
    }
}
