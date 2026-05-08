using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cAMERA241 : MonoBehaviour
{
    [Header("Rotation")]
    public Transform target;           // Объект персонажа
    public float mouseSensitivity = 3f;
    public float rotationSmoothTime = 0.12f;
    public Vector2 pitchMinMax = new Vector2(-40, 85); // Ограничение наклона вверх/вниз

    [Header("Collision")]
    public Transform cameraTransform;  // Ссылка на саму камеру
    public LayerMask collisionLayers;  // Слои препятствий (выберите всё, кроме Player)
    public float maxDistance = 3.5f;   // Дистанция в покое
    public float minDistance = 0.8f;   // Мин. дистанция при столкновении
    public float cameraSphereRadius = 0.2f; // "Толщина" камеры для проверок

    float yaw;   // Вращение влево-вправо
    float pitch; // Вращение вверх-вниз
    Vector3 currentRotation;
    Vector3 rotationSmoothVelocity;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        if (cameraTransform == null) cameraTransform = Camera.main.transform;
    }

    void LateUpdate()
    {
        yaw += Input.GetAxis("Mouse X") * mouseSensitivity;
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);

        currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yaw), ref rotationSmoothVelocity, rotationSmoothTime);
        transform.eulerAngles = currentRotation;
        transform.position = target.position;

        CheckCollision();
    }

    void CheckCollision()
    {
        Vector3 desiredLocalPos = new Vector3(0, 0, -maxDistance);
        Vector3 worldDesiredPos = transform.TransformPoint(desiredLocalPos);

        RaycastHit hit;
        if (Physics.SphereCast(transform.position, cameraSphereRadius, worldDesiredPos - transform.position, out hit, maxDistance, collisionLayers))
        {
            float currentDistance = Mathf.Clamp(hit.distance, minDistance, maxDistance);
            cameraTransform.localPosition = new Vector3(0, 0, -currentDistance);
        }
        else
        {
            cameraTransform.localPosition = Vector3.Lerp(cameraTransform.localPosition, desiredLocalPos, Time.deltaTime * 5f);
        }
    }
}
