using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class LevelManagerScript : MonoBehaviour
{
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void GoToLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void GoToLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GoToSavedLevel1()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("u1Level", "Level 1"));
        PlayerPrefs.SetInt("u1", 1);
        PlayerPrefs.Save();
    }
    public void GoToSavedLevel2()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("u2Level", "Level 1"));
        PlayerPrefs.SetInt("u2", 1);
        PlayerPrefs.Save();
    }
    public void GoToSavedLevel3()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("u3Level", "Level 1"));
        PlayerPrefs.SetInt("u3", 1);
        PlayerPrefs.Save();
    }
    public void SavesLevel1()
    {
        if (PlayerPrefs.GetInt("u1", 0) != 0)
        {
            PlayerPrefs.SetString("u1Level", "Level 1");
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("u1", 0);
            PlayerPrefs.Save();

        } else if (PlayerPrefs.GetInt("u2", 0) != 0)
        {
            PlayerPrefs.SetString("u2Level", "Level 1");
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("u2", 0);
            PlayerPrefs.Save();
        } else
        {
            PlayerPrefs.SetString("u3Level", "Level 1");
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("u3", 0);
            PlayerPrefs.Save();
        }
    }
    public void SavesLevel2()
    {
        if (PlayerPrefs.GetInt("u1", 0) != 0)
        {
            PlayerPrefs.SetString("u1Level", "Level 2");
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("u1", 0);
            PlayerPrefs.Save();

        }
        else if (PlayerPrefs.GetInt("u2", 0) != 0)
        {
            PlayerPrefs.SetString("u2Level", "Level 2");
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("u2", 0);
            PlayerPrefs.Save();
        }
        else
        {
            PlayerPrefs.SetString("u3Level", "Level 2");
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("u3", 0);
            PlayerPrefs.Save();
        }
    }
    public void SavesLevel3()
    {
        if (PlayerPrefs.GetInt("u1", 0) != 0)
        {
            PlayerPrefs.SetString("u1Level", "Level 3");
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("u1", 0);
            PlayerPrefs.Save();

        }
        else if (PlayerPrefs.GetInt("u2", 0) != 0)
        {
            PlayerPrefs.SetString("u2Level", "Level 3");
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("u2", 0);
            PlayerPrefs.Save();
        }
        else
        {
            PlayerPrefs.SetString("u3Level", "Level 3");
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("u3", 0);
            PlayerPrefs.Save();
        }
    }
}
