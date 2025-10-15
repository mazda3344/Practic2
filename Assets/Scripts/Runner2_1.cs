using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner2_1 : MonoBehaviour
{
    public List<Transform> runnersList;
    public int runnersIndex;
    public Transform currentRunner;
    public Transform nextRunner;
    public float speed = 12f;
    void Start()
    {
        
        if (runnersIndex >= 0 && runnersIndex < runnersList.Count)
        {
            currentRunner = runnersList[runnersIndex];
            nextRunner = runnersList[runnersIndex+1];
        }
        else
        {
            currentRunner = runnersList[0];
            nextRunner = runnersList[1];
        }
    }
    void Update()
    {
        if (currentRunner.position == nextRunner.position)
        {
            runnersIndex++;
            if (runnersIndex >= runnersList.Count)
            {
                runnersIndex = 0;
            }
            currentRunner = nextRunner;
            nextRunner = runnersList[runnersIndex];
        }
        currentRunner.position = Vector3.MoveTowards(currentRunner.position, nextRunner.position, Time.deltaTime * speed);
    }
}