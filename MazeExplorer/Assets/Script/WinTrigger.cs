using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject winUI;    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowWinUI();
        }
    }

    private void ShowWinUI()
    {
        winUI.SetActive(true);   
    }
}
