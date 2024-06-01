using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("u1", 0) != 0)
        {
            SceneManager.LoadScene(PlayerPrefs.GetString("u1Level", "Level 1"));
        } else if (PlayerPrefs.GetInt("u2", 0) != 0)
        {
            SceneManager.LoadScene(PlayerPrefs.GetString("u2Level", "Level 1"));
        } else if (PlayerPrefs.GetInt("u3", 0) != 0)
        {
            SceneManager.LoadScene(PlayerPrefs.GetString("u3Level", "Level 1"));
        } else
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
