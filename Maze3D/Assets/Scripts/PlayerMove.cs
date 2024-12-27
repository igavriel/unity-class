using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 90;

    private Rigidbody rb;
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input for horizontal and vertical movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // set the is walking animation
        bool isWalking = moveHorizontal != 0 || moveVertical != 0;
        animator.SetBool("IsWalking", isWalking);

        // Rotate the player
        transform.Rotate(Vector3.up * moveHorizontal * rotationSpeed * Time.deltaTime);

        // Calculate movement in the horizontal plane only
        Vector3 movement = transform.forward;
        movement.y = 0; // Remove vertical component
        movement.Normalize(); // Normalize to maintain consistent speed
        movement *= moveVertical * moveSpeed;

        // Apply movement
        rb.MovePosition(rb.position + movement * Time.deltaTime);
    }
}
