using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour
{

    public void ReloadLevel()
    {
        Destroy(GameObject.Find("Level 1"));
        SceneManager.LoadSceneAsync(1);
    }
    public GameObject currentLevel;
    public GameObject nextLevel;
    public void GoToLevel()
    {
        currentLevel.SetActive(false);
        nextLevel.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
