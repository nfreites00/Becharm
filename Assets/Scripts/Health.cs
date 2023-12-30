using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * This script manages the health.
 */

public class Health : MonoBehaviour
{
    public Image healthBar;
    public float health;
    [HideInInspector] public float maxHealth;
    [SerializeField] PlayerMovement playerMovement;

    private void Start()
    {
        maxHealth = health;
    }

    /*
     * This function keeps track of the health bar.
     * When the player's health is zero, stop player
     * movement. Also adds a delay before the game 
     * over occurs.
     * 
     * TO DO: adjust code so enemies can't push player
     * after death.
     * 
     * TO DO: adjust code so after delay, game over
     * screen pops up.
     */
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if (health <= 0) 
        {
            playerMovement.enabled = false;
            StartCoroutine(DelayDeath());
        }
    }

    IEnumerator DelayDeath()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
