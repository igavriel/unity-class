using UnityEngine;

public class ObjectCollector : MonoBehaviour
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
            Collect();
        }
    }

    private void Collect()
    {
        Debug.Log("Object collected!");


        // You can add effects here, like sound or particles
        AudioSource.PlayClipAtPoint(sound.clip, transform.position);
//        CanvasControl.Instance.CollectCoin();
        // SpawnCollectionParticles();

        // Destroy the coin
        Destroy(gameObject, destroyDelay);
    }
}
