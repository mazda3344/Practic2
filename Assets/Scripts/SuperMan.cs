using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SuperMan : MonoBehaviour
{
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
        }
        // if (collision.gameObject.tag == tagBadGuy)
        // {
        //     Debug.Log("BadGuy detected by Layer");
        // }
    }
    
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("lost...");
    }
}
