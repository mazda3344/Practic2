using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyimage : MonoBehaviour
{
    // Перетащите сюда ваш GameObject в инспекторе Unity
    [SerializeField] private GameObject objectToDestroy;

    private void Start()
    {
        if (objectToDestroy != null)
        {
            // Удаляет объект ровно через 3 секунды после старта
            Destroy(objectToDestroy, 5f);
        }
    }
}
