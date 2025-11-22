using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST1 : MonoBehaviour
{
    public string ungravity = "ungravity";
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ungravity)
        {
            GetComponent<Rigidbody>().useGravity = false;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}
