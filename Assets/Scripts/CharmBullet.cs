using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script 
 */

public class CharmBullet : MonoBehaviour
{
    // public GameObject hitEffect;
    public int damage = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        // Destroy(effect, 4f);
        //if(collision.gameObject.CompareTag("Bullet"))
        //{
        //    Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        //}

        if(collision.gameObject.TryGetComponent<Enemy_AI>(out Enemy_AI enemy))
        {
            enemy.DamageTaken(damage);
        }

        Destroy(gameObject);
    }

    private void Update()
    {
        Destroy(gameObject, 2f);
    }
}
