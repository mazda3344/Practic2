using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageE : MonoBehaviour
{
    public GameObject imageObject; // Перетащите сюда ваш UI Image объект в инспекторе

    private void OnTriggerEnter(Collider other)
    {
        // Проверка, что подошел игрок (например, с тегом "Player")
        if (other.CompareTag("Door"))
        {
            imageObject.SetActive(true); // Включаем изображение
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            imageObject.SetActive(false); // Выключаем изображение
        }
    }
}