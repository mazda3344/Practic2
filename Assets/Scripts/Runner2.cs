using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner2 : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public Transform point3;
    public Transform point4;
    public Transform point5;
    public Transform point6;
    public Transform point7;
    public float Speed;
    public bool Go;
    private Vector3 target;
    void Start()
    {
        target = point1.position;
    }
    void Update()
    {
        transform.LookAt(point1);
        transform.Rotate(0, 0, 1);
        if(Go)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * Speed);
        }
        if(transform.position == target)
        {
            
        }
    }
}