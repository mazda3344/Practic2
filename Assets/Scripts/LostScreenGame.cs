using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LostScreenGame : MonoBehaviour
{
    public Button RestartIfLost;
    public void RestartGamy()
    {
        SceneManager.LoadScene(0);
    }
}
