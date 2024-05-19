using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject PauseMenuBehavior;
    public AudioSource Audio;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Audio.Pause();
            Pause();
        }
    }
    public void Resume()
    {
        PauseMenuBehavior.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Audio.Play();
    }
    void Pause()
    {
        PauseMenuBehavior.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}