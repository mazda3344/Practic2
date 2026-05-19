using UnityEngine;
using UnityEngine.SceneManagement;

public class Leave : MonoBehaviour
{
    // Вариант 1: Полное закрытие приложения (выход из игры)
    public void CloseGame()
    {
        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    // Вариант 2: Выгрузка текущей сцены (если запущено несколько сцен одновременно)
    public void UnloadCurrentScene()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        SceneManager.UnloadSceneAsync(activeScene.buildIndex);
    }
}

