using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Dead : MonoBehaviour
{
    public TextMeshProUGUI Coin;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Death tregger"))
        {
            Coin.text = "0";
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}