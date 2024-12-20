using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    public float interactionDistance = 2f;
    public KeyCode interactionKey = KeyCode.E;
    public float destroyDelay = 1f; // Time delay before destroying the chest

    private GameObject player;
    private bool isInRange = false;
    private bool isOpened = false;
    private Animator animator;
    private AudioSource sound;


    void Start()
    {
        player = GameObject.FindWithTag("Player");
        animator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (player != null)
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);
            isInRange = distance <= interactionDistance;

            if (isInRange && !isOpened && Input.GetKeyDown(interactionKey))
            {
                OpenChest();
            }
        }
    }

    void OpenChest()
    {
        isOpened = true;
        Debug.Log("Chest opened!");

        CanvasControl.Instance.CollectChest();
        AudioSource.PlayClipAtPoint(sound.clip, transform.position);

        // Add your chest opening logic here (e.g., reveal contents, give rewards)
        // You can also add sound effects or particle systems here
        animator.SetTrigger("Open");
    }
}
