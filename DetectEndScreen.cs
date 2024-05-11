using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEndScreen : MonoBehaviour
{
    public AudioSource Audio;
    public GameObject EndScreen1, EndScreen2;

    void Update()
    {
        if (EndScreen1.activeSelf || EndScreen2.activeSelf)
        {
            Audio.Pause();
        }
    }
}
