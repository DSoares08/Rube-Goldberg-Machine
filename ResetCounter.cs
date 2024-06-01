using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreditsController.count = 1;
    }
}
