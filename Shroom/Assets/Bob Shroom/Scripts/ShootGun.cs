using UnityEngine;

public class ShootGun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootingPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, shootingPoint.position,shootingPoint.rotation);
        }
    }
}
