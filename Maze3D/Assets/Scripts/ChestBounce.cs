using System;
using UnityEngine;

public class ChestJump : MonoBehaviour
{
    public float bounceHeight = 0.1f;
    public float bounceSpeed = 2f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newY = startPosition.y + Math.Abs((Mathf.Sin(Time.time * bounceSpeed) * bounceHeight));
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
