using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    public GameObject Effective;
    public GameObject Blood;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Death tregger"))
        {
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
