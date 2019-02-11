using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTracker : MonoBehaviour
{
    public string scene;

    private void OnEnable()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
