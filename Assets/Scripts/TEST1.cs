using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST1 : MonoBehaviour
{
    public float Radius;
    public float Power;
    public float TimeToBoom;

    private void Start()
    {

    }
    void Update()
    {
        TimeToBoom -= Time.deltaTime;
        if (TimeToBoom <= 0)
        {
            Boom();
        }
    }
    void Boom()
    {
        Rigidbody[] blocks = FindObjectsOfType<Rigidbody>();
        
        foreach (Rigidbody B in blocks)
        {
            if (Vector3.Distance(transform.position, B.transform.position) < Radius)
            {
                Vector3 direcetion = B.transform.position - transform.position;
                B.AddForce(direcetion.normalized * Power * (Radius - Vector3.Distance(transform.position, B.transform.position)));
            }
        }
        
        TimeToBoom = 0;
    }
}
