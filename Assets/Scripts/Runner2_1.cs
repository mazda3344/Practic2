using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Runner2_1 : MonoBehaviour
{
    public List<Runner> runnersList;
    // public List<Transform> runnersList;
    public int runnersIndex;
    public Runner currentRunner;
    // public Transform currentRunner;
    public Runner nextRunner;
    // public Transform nextRunner;
    public float speed = 25f;
    public GameObject fakel;
    void Start()
    {
        if (runnersIndex >= 0 && runnersIndex < runnersList.Count)
        {
            currentRunner = runnersList[runnersIndex];
            nextRunner = runnersList[runnersIndex + 1];
        }
        else
        {
            currentRunner = runnersList[0];
            nextRunner = runnersList[1];
        }
        fakel.transform.SetParent(currentRunner.wrist);
        fakel.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
    }

    void Update()
    {
        currentRunner.transform.LookAt(nextRunner.transform);
        if (currentRunner.transform.position == nextRunner.transform.position)
        {
            runnersIndex++;
            if (runnersIndex >= runnersList.Count)
            {
                runnersIndex = 0;
            }
            currentRunner = nextRunner;
            nextRunner = runnersList[runnersIndex];
            fakel.transform.SetParent(currentRunner.wrist);
            fakel.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
        }
        currentRunner.transform.position = Vector3.MoveTowards(currentRunner.transform.position, nextRunner.transform.position, Time.deltaTime * speed);
    }
}