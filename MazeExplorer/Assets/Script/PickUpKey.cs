using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public Component doorCollider;
    public GameObject key;
   
    void Start()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            doorCollider.GetComponent<BoxCollider>().enabled = true;

            if (Input.GetKey(KeyCode.E))
            {
                key.SetActive(false);
            }
        }
    }
}
