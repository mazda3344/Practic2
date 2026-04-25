using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next4 : MonoBehaviour
{
  private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Next4"))
        {
            SceneManager.LoadScene(5);
        }
    }
}
