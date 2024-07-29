using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public HealthBar healthBar;
    public int heal = 20;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }
    void Pickup(Collider player)
    {
        PlayerHealth stats = player.GetComponent<PlayerHealth>();

        if (stats.health < 100) 
        {
            stats.health += heal;
            healthBar.SetMaxHealth(stats.health);
        }
        else
        {
            heal= 0;
        }


        Destroy(gameObject);
    }

    
}
