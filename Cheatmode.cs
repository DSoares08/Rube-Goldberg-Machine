using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cheatmode : MonoBehaviour
{
    public GameObject a;
    public int gravity;
    public Button ab;
    public Rigidbody2D b1;
    public Rigidbody2D b2;
    public Rigidbody2D b3;

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.C) && Input.GetKeyDown(KeyCode.A)) || (InputManager.var1 && InputManager.var2))
        {
            if (a.activeSelf)
            {
                b1.gravityScale = gravity;
                b2.gravityScale = gravity;
                b3.gravityScale = gravity;
                ab.onClick.Invoke();
            }
        }
    }
}
