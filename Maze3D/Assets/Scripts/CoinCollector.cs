using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public float destroyDelay = 0.5f; // Time delay before destroying the chest

    private AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

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

        CanvasControl.Instance.CollectCoin();
        AudioSource.PlayClipAtPoint(sound.clip, transform.position);

        // You can add effects here, like sound or particles
        // PlayCollectionSound();
        // SpawnCollectionParticles();

        // Destroy the coin
        Destroy(gameObject, destroyDelay);
    }
}
