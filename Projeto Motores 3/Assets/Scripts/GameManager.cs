using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
        LoadSceneIfNotLoaded("GetStarted_Scene");

        
        LoadSceneIfNotLoaded("GUI");
    }

    private void LoadSceneIfNotLoaded(string sceneName)
    {
        if (!SceneManager.GetSceneByName(sceneName).isLoaded)
        {
            SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        }
    }
}