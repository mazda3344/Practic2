using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lost : MonoBehaviour
{
    public string tagBadGuy = "BadGuy"; 
    public GameObject HameOverScreen;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == tagBadGuy)
        {
            Debug.Log("BadGuy detected by Tag");
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
