using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript2 : MonoBehaviour
{
    public Transform target; // Игрок
    public float sensitivity = 5f; // Чувствительность мыши
    private float rotationX, rotationY;

    void LateUpdate()
    {
        // Получение ввода мыши
        rotationX += Input.GetAxis("Mouse X") * sensitivity;
        rotationY -= Input.GetAxis("Mouse Y") * sensitivity;
        rotationY = Mathf.Clamp(rotationY, -30f, 60f); // Ограничение по вертикали

        // Поворот камеры вокруг цели
        transform.rotation = Quaternion.Euler(rotationY, rotationX, 0);
        
        // Позиция камеры относительно игрока
        Vector3 offset = new Vector3(0, 2f, -5f); // Смещение
        transform.position = target.position + transform.rotation * offset;
    }
}
