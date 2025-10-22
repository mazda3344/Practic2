using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Runner_1 : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public Transform point3;
    public Transform point4;
    public Transform point5;
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
            if(target == point1.position)
            {
                target = point2.position;
            }
            else if(target == point2.position)
            {
                target = point3.position;
            }
            else if(target == point3.position)
            {
                target = point4.position;
            }
            else if(target == point4.position)
            {
                target = point5.position;
            }
            else if(target == point5.position)
            {
                target = point1.position;
            }
        }
    }
}
