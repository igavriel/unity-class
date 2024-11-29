using UnityEngine;

public class CarController : MonoBehaviour
{
    public float acceleration = 10f;
    public float steering = 1.5f;
    public float gravity = 20f;
    public float maxSpeed = 50f;
    public float tiltFactor = 2f; // Controls how much the car tilts when turning
    public float tiltSpeed = 2f; // Controls how fast the car tilts

    private Rigidbody rb;
    private float currentSpeed = 0f;
    private float currentRotation = 0f;
    private float currentTilt = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Get input for acceleration and steering
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate acceleration
        currentSpeed += verticalInput * acceleration * Time.fixedDeltaTime;
        currentSpeed = Mathf.Clamp(currentSpeed, -maxSpeed / 2, maxSpeed);

        // Apply drag when no input
        if (verticalInput == 0)
        {
            currentSpeed = Mathf.MoveTowards(currentSpeed, 0, acceleration * Time.fixedDeltaTime);
        }

        // Calculate steering
        currentRotation = horizontalInput * steering * currentSpeed * Time.fixedDeltaTime;

        // Calculate tilt based on steering input
        float targetTilt = -horizontalInput * tiltFactor;
        currentTilt = Mathf.Lerp(currentTilt, targetTilt, Time.fixedDeltaTime * tiltSpeed);

        // Create a rotation for the car, including tilt
        Quaternion rot = transform.rotation * Quaternion.Euler(0, currentRotation, currentTilt);

        // Move the car
        Vector3 movement = transform.forward * currentSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
        rb.MoveRotation(rot);

        // Apply gravity
        rb.AddForce(Vector3.down * gravity);
    }
}