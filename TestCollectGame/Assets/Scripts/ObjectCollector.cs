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
      if (other.CompareTag("Player"))
        {
            Collect();
        }
    }

    private void Collect()
    {
        Debug.Log("Object collected!");

        if (sound)
        {   // You can add effects here, like sound or particles
            AudioSource.PlayClipAtPoint(sound.clip, transform.position);
        }

        ScoreManager.AddScore(objectValue);

        // SpawnCollectionParticles();

        // Destroy the object
        Destroy(gameObject, destroyDelay);
    }
}
