using System.Collections;
using System.Collections.Generic;
// using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlerPlayer3 : MonoBehaviour
{

    public int index = 5;
    public void OnClick()
    {
        SceneManager.LoadScene(index);
    }
}
