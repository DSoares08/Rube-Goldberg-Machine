using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("u1", 0) != 0)
        {
            PlayerPrefs.SetInt("u1", 0);
            PlayerPrefs.SetString("u1Level", "Level 1");
            PlayerPrefs.Save();
        } else if (PlayerPrefs.GetInt("u2", 0) != 0)
        {
            PlayerPrefs.SetInt("u2", 0);
            PlayerPrefs.SetString("u2Level", "Level 1");
            PlayerPrefs.Save();
        } else
        {
            PlayerPrefs.SetInt("u3", 0);
            PlayerPrefs.SetString("u3Level", "Level 1");
            PlayerPrefs.Save();
        }
    }


}
