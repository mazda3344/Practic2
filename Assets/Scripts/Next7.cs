using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next7 : MonoBehaviour
{
  private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Next7"))
        {
            SceneManager.LoadScene(8);
        }
    }
}