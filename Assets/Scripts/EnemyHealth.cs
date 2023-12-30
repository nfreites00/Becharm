using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyHealth : MonoBehaviour
{
    /*
    public float speed;
    //public float damage;
    private float distance;
    */

    public float damage;
    [SerializeField] public float enemyHealth;
    [SerializeField] public float enemyMaxHealth;

    //public GameObject player;
    [SerializeField] PlayerHealth playerHealth;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = enemyMaxHealth;
        target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    /*
    void Update()
    {
        distance = UnityEngine.Vector2.Distance(transform.position, player.transform.position);        
        UnityEngine.Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.position = UnityEngine.Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        transform.rotation = UnityEngine.Quaternion.Euler(UnityEngine.Vector3.forward * angle);
        
    }
    */

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.CompareTag("Enemy")) || (collision.gameObject.CompareTag("EnemyBullet")))
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            target.GetComponent<PlayerHealth>().health -= damage;
        }
    }

    public void DamageTaken(float damageAmount)
    {
        enemyHealth -= damageAmount;

        if (enemyHealth <= 0)
        {
            UIManager.UIManagerInstance.charmCount++;
            UIManager.UIManagerInstance.UpdateCharmCounterUI();
            Destroy(gameObject);
        }    
    }
}
