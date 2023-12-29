using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public Transform pointOfFire;
    public GameObject bulletPrefab;

    public float bulletForce = 10.0f;

    private float shotFiredCooldown = 1f;

    // Update is called once per frame
    void Update()
    {
        shotFiredCooldown -= Time.deltaTime;

        if (shotFiredCooldown <= 0f)
        {
            Shoot();
            shotFiredCooldown = 1f;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, pointOfFire.position, pointOfFire.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(pointOfFire.up * bulletForce, ForceMode2D.Impulse);
    }
}
