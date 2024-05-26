using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public static bool WasPlaying1 = false;
    public static bool WasPlaying2 = false;

    public GameObject PauseMenuBehavior;
    public GameObject AuxScreen1;
    public GameObject AuxScreen2;
    public GameObject AuxScreen3;
    public GameObject AuxScreen4;
    public AudioSource Audio;
    public AudioSource Audio1;
    public AudioSource Audio2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && !AuxScreen1.activeSelf && !AuxScreen2.activeSelf && !AuxScreen3.activeSelf && !AuxScreen4.activeSelf)
        {
            Audio.Pause();
            if (Audio1.isPlaying)
            {
                WasPlaying1 = true;
            }
            if (Audio2.isPlaying)
            {
                WasPlaying2 = true;
            }
            Audio1.Pause();
            Audio2.Pause();
            Pause();
        }
    }
    public void Resume()
    {
        PauseMenuBehavior.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Audio.Play();
        if (WasPlaying2)
        {
            Audio2.Play();
            WasPlaying2 = false;
        }
        if (WasPlaying1)
        {
            Audio1.Play();
            WasPlaying1 = false;
        }
    }
    void Pause()
    {
        PauseMenuBehavior.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}