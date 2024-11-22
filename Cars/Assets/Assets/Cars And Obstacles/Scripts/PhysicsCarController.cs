using UnityEngine;


public class PhysicsCarController : MonoBehaviour
{
    public float moveForce = 1500f;  // Force applied for forward/backward movement
    public float turnSpeed = 150f; // Torque applied for turning
 
    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Get input for movement and turning
        float moveInput = Input.GetAxis("Vertical");   // W/S or Up/Down arrow keys
        float turnInput = Input.GetAxis("Horizontal"); // A/D or Left/Right arrow keys


        rb.AddForce(transform.forward * moveInput * moveForce * Time.fixedDeltaTime);


        // Apply torque for turning
        transform.Rotate(Vector3.up, turnInput * turnSpeed * Time.deltaTime);
    }
}
