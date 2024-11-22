using UnityEngine;

public class SimpleCarController : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed for forward/backward movement
    public float turnSpeed = 100f; // Speed for turning

    void Update()
    {
        // Get input for forward/backward movement
        float moveInput = Input.GetAxis("Vertical"); // W/S or Up/Down arrow keys
        
        // Get input for left/right turning
        float turnInput = Input.GetAxis("Horizontal"); // A/D or Left/Right arrow keys

        // Move the car forward or backward
        transform.Translate(Vector3.forward * moveInput * moveSpeed * Time.deltaTime);

        // Rotate the car left or right
        transform.Rotate(Vector3.up, turnInput * turnSpeed * Time.deltaTime);
    }
}
