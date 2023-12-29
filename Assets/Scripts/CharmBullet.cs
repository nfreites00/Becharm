using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script 
 */

public class CharmBullet : MonoBehaviour
{
    // public GameObject hitEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        // Destroy(effect, 4f);
        Destroy(gameObject);
    }

    private void Update()
    {
        Destroy(gameObject, 2f);
    }
}
