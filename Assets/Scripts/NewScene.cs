using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{
    public void ToNewScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void CloseApplication()
    {
        Application.Quit();
    }
}
