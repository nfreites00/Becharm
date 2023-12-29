using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * This script manages the health of the player.
 */

public class PlayerHealth : MonoBehaviour
{
    private float health;
    private float maxHealth = 100;
    public Image healthBar;

    private void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
    }
}
