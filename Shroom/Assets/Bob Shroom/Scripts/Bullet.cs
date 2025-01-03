using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float power = 10;
    Rigidbody body;
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.AddForce(transform.forward * power, ForceMode.Impulse);
        Destroy(gameObject, 3f);
    }

}

