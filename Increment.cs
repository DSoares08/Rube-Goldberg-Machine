using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increment : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        CreditsController.count++;
    }
    void Update() {
        Debug.Log(CreditsController.count);
    }    
}
