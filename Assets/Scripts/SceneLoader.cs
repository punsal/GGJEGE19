using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OpenGame()
    {
        SceneManager.LoadScene("Intro Scene", LoadSceneMode.Single);
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("_", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("Credits Scene", LoadSceneMode.Single);
    }
}
