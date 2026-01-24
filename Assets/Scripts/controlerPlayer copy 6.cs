using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlerPlayer7 : MonoBehaviour
{
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Death tregger"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
