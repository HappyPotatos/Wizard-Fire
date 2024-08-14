using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject InstantiatedBullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // Instantiates a bullet at the fire point's position and rotation
        Destroy(InstantiatedBullet.gameObject, 20f / 60f);
    }   
}
