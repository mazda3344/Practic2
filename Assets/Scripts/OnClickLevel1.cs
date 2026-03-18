using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickLevel1 : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(0);
    }
}
