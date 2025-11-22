using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billiard : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Rigidbody>().AddForce (0, 0, 9990, ForceMode.Force);
    }
}
