using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the object's movement

    void Update()
    {
        // Get input from arrow keys or WASD
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        // Move the object
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }
}