using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroygdfzhzhj : MonoBehaviour
{
     void Start()
    {

    }  
     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, 4f);
        }
    }
}
