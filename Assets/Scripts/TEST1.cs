using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST1 : MonoBehaviour
{
    private void start()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, 10000);
    }
    // private void Start()
    // {
        
    // }
    // void Update()
    // {
        
    // }
}
