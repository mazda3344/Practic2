using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST1 : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, 100, ForceMode.Impulse);
    }
    // private void Start()
    // {
        
    // }
    // void Update()
    // {
        
    // }
}
