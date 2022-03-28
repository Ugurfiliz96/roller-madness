using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour
{
    
    public void RestartGame()
    {
        print("Restart");
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }
    public void NextLevelGame()
    {
        print("Next Level Loaded");
        int scene = SceneManager.GetActiveScene().buildIndex + 1;
        int sceneIndex = SceneManager.sceneCountInBuildSettings - 1;
        if (scene<=sceneIndex)
        {
            SceneManager.LoadScene(scene);
        }
        if (scene > sceneIndex)
        {
            SceneManager.LoadScene(0);
        }
    }
}
