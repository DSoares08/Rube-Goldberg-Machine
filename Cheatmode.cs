using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cheatmode : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;
    public Button ab;
    public Button bb;
    public Button cb;
    public Button db;
    public Button eb;
    public Button fb;
    public Rigidbody2D b1;
    public Rigidbody2D b2;
    public Rigidbody2D b3;
    public Rigidbody2D b4;
    public Rigidbody2D b5;

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.C) && Input.GetKeyDown(KeyCode.A)) || (Event.current.keyCode == KeyCode.A))
        {
            if (a.activeSelf)
            {
                b1.gravityScale = 1;
                b2.gravityScale = 1;
                b3.gravityScale = 1;
                ab.onClick.Invoke();
            }
            if (b.activeSelf)
            {
                b4.gravityScale = 1;
                bb.onClick.Invoke();
            }
            if (c.activeSelf)
            {
                b1.gravityScale = 1;
                b2.gravityScale = 1;
                b3.gravityScale = 1;
                cb.onClick.Invoke();
            }
            if (d.activeSelf)
            {
                b4.gravityScale = 1;
                db.onClick.Invoke();
            }
            if (e.activeSelf)
            {
                b5.gravityScale = 1;
                eb.onClick.Invoke();
            }
            if (f.activeSelf)
            {
                b5.gravityScale = 1;
                fb.onClick.Invoke();
            }
        }
    }
}
