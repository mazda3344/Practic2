using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoot : MonoBehaviour
{
    public Transform target; // Целевая позиция
    public float smoothTime = 0.3f; // Время сглаживания (меньше = быстрее)
    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target != null)
        {
            // Плавное перемещение к цели
            transform.position = Vector3.SmoothDamp(transform.position, target.position, ref velocity, smoothTime);
        }
    }
}
