using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lost : MonoBehaviour
{
    public string tagBadGuy = "BadGuy"; 
    public GameObject HameOverScreen;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == tagBadGuy)
        {
            Debug.Log("lost");
            HameOverScreen.SetActive(true);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
