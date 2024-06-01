using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolumeData : MonoBehaviour
{
    public AudioSource a;

     void Update()
     {
        PlayerPrefs.SetFloat("Volume", a.volume);
        PlayerPrefs.Save();
     }

    void Start()
    {
        if (PlayerPrefs.GetInt("u1", 0) != 0)
        {
            PlayerPrefs.SetString("u1Level", SceneManager.GetActiveScene().name);
            PlayerPrefs.Save();
        } else if (PlayerPrefs.GetInt("u2", 0) != 0)
        {
            PlayerPrefs.SetString("u2Level", SceneManager.GetActiveScene().name);
            PlayerPrefs.Save();
        } else
        {
            PlayerPrefs.SetString("u3Level", SceneManager.GetActiveScene().name);
            PlayerPrefs.Save();
        }
        a.volume = PlayerPrefs.GetFloat("Volume", 1.0f);
    }
}
