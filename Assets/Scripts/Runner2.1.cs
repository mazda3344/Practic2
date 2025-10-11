using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner2 : MonoBehaviour
{
    public int pointIndex;
    public List<Transform> pointList;
    public int runnersIndex;
    public List<Transform> runnersList;
    public Transform currentPoint;
    public float speed = 10f;
    void Start()
    {
        if (pointIndex >= 0 && pointIndex < pointList.Count)
        {
            currentPoint = pointList[pointIndex];
        }
        else
        {
            currentPoint = pointList[0];
        }
    }
    void Update()
    {
        if (gameObject.transform.position == currentPoint.position)
        {
            pointIndex++;
            if (pointIndex >= pointList.Count)
            {
                pointIndex = 0;
            }
            currentPoint = pointList[pointIndex];
        }
        transform.position = Vector3.MoveTowards(transform.position, currentPoint.position, Time.deltaTime * speed);
    }
}