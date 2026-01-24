using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlerPlayer : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(0);
    }
    
}
