using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SuperMan : MonoBehaviour
{
    public float TimeToBoom;
    public float Power;
    public float Radius;
    public string tagBadGuy = "BadGuy";
    // public int layerBadGuy = LayerMask.GetMask("BadGuy");

    // void Reset()
    // {
    //     tagBadGuy = "BadGuy";
    //     layerBadGuy = LayerMask.GetMask("BadGuy");
    // }
    private void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("SuperMan::OnCollisionEnter(); -1- collision.gameObject:" + collision.gameObject);
        // Debug.Log("SuperMan::OnCollisionEnter(); -2- collision.gameObject.tag:" + collision.gameObject.tag);
        Debug.Log("SuperMan::OnCollisionEnter(); -3- tagBadGuy:" + tagBadGuy);
        // Debug.Log("SuperMan::OnCollisionEnter(); -4- collision.gameObject.layer:" + collision.gameObject.layer);
        // Debug.Log("SuperMan::OnCollisionEnter(); -5- layerBadGuy.value:" + layerBadGuy);
        if (collision.gameObject.tag == tagBadGuy)
        {
            Debug.Log("BadGuy detected by Tag");

            if (TimeToBoom <= 0)
            {
                Boom();

            }
        }
        // if (collision.gameObject.tag == tagBadGuy)
        // {
        //     Debug.Log("BadGuy detected by Layer");
        // }
    }
    private void Boom()
    {
        Rigidbody[] blocks = FindObjectsOfType<Rigidbody>();
        
        foreach (Rigidbody B in blocks)
        {
            if (Vector3.Distance(transform.position, B.transform.position) < Radius)
            {
                Vector3 direcetion = B.transform.position - transform.position;
                B.AddForce(direcetion.normalized * Power * (Radius - Vector3.Distance(transform.position, B.transform.position)));
            }
            TimeToBoom = 0;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("lost...");
    }
}
