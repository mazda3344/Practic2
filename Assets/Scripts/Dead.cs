using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        // Проверка тега объекта, с которым произошло столкновение
        if (collision.gameObject.CompareTag("Death tregger"))
        {
            // Перезагрузка активной сцены
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
