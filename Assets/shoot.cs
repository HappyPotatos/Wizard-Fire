using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float shootDelay = 0.3f; // Delay between each shot in seconds

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0f, shootDelay); // Starts shooting with a delay of 0 seconds and repeats every shootDelay seconds
    }

    void Shoot()
    {
        GameObject InstantiatedBullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // Instantiates a bullet at the fire point's position and rotation
        Destroy(InstantiatedBullet.gameObject, 20f);

    }
}
