using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChanger : MonoBehaviour
{
    public GameObject lev1;
    public GameObject lev2;
    public GameObject lev3;
    public Camera camera;
    public Color black = Color.black;
    void Update()
    {
        if (lev1.activeSelf || lev2.activeSelf || lev3.activeSelf) 
        {
            camera.backgroundColor = black;
        }
    }
}
