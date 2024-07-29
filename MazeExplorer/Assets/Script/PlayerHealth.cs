using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 100;
    public HealthBar healthBar;
    public GameObject deathUi;
    public PowerUp heal;
    void Start()
    {
        healthBar.SetMaxHealth(maxHealth);
        health = maxHealth;
    }
    public void takeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            deathUi.SetActive(true);
        }
        else if(health < maxHealth) 
        {
            healthBar.SethHealth(health);
        }

    }
    public void takeHeal(int amount)
    { 
        health += amount;

        if (health <= maxHealth) 
        {
            healthBar.SethHealth(health);
        }
    }



}
