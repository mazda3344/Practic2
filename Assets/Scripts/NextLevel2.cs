using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Next2"))
        {
<<<<<<< HEAD
            SceneManager.LoadScene(2);
=======
            SceneManager.LoadScene(3);
>>>>>>> dd9de9c64473e7a76a6005c44416abf768395e3a
        }
    }
}
