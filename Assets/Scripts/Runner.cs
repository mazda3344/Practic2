using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Runner : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public Transform point3;
    public Transform point4;
    public Transform point5;
    public object runnerr;
    void Start()
    {
        
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, point1.position, Time.deltaTime);
    }
}
