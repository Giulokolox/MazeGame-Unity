using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private PlayerHealth playerHealth; 
    public GameObject deathUi;
    public float speed = 5f;

    private Rigidbody rb;

    void Start()
    {
        //currentHealth = maxHealth;
        //healthBar.SetMaxHealth(maxHealth);
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
 
     
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal,0 , moveVertical);

        movement = movement.normalized;

        rb.velocity = movement * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Life")
        {
            playerHealth.takeHeal(30);

        }
    }
}
