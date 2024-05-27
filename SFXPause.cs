using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SFXPause : MonoBehaviour
{
    public AudioSource Audio;
    public AudioSource Audio2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Audio.Pause();
            Audio2.Pause();
        }
    }
}
