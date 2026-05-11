using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Dead : MonoBehaviour
{
<<<<<<< HEAD
    public TextMeshProUGUI Coin;
    
=======
    public GameObject Effective;
    public GameObject Blood;
>>>>>>> dd9de9c64473e7a76a6005c44416abf768395e3a
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Death tregger"))
        {
<<<<<<< HEAD
            Coin.text = "0";
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
=======
            Blood.SetActive(true);
            Effective.SetActive(true);
            Invoke(nameof(RestartScene), 0.6f);
        }
    }

    private void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
>>>>>>> dd9de9c64473e7a76a6005c44416abf768395e3a
