using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel3_13 : MonoBehaviour
{
    public GameObject txt;
    public GameObject Eff;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Next3_13"))
        {
            txt.SetActive(true);
            Eff.SetActive(true);
        }
    }
}
