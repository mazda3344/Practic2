using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnrandom : MonoBehaviour
{
    public GameObject itemPrefab;
    public float startTime = 1f;
    public float repeatRate = 5f;

    void Start()
    {
        InvokeRepeating("SpawnObject", startTime, repeatRate);
    }

    void SpawnObject()
    {
        Instantiate(itemPrefab, transform.position, Quaternion.identity);
    }
}
