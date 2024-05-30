using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailCheck : MonoBehaviour
{ 
    public float stationaryTime = 5.0f;
    private Vector3 lastPosition;
    private float timer = 0.0f;
    public GameObject failureScreen;
    public SpriteRenderer ball;
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public float leftx;
    public float rightx;
    public float bottomy;
    public float topy;

    void Start()
    {
    // Initialize the last position to the current position of the sprite
        lastPosition = ball.transform.position;
    }

    void Update()
    {
        if (ball.transform.position.x < leftx ||  ball.transform.position.x > rightx || ball.transform.position.y < bottomy || ball.transform.position.y > topy)
        {
            OnStationary();
        }
        if (ball.transform.position == lastPosition && !s1.activeSelf && !s2.activeSelf && !s3.activeSelf && !failureScreen.activeSelf && !s4.activeSelf)
        {
            timer += Time.deltaTime;

        // Check if the sprite has been stationary for the required time
            if (timer >= stationaryTime)
            {
            // Trigger your event here
                OnStationary();

            // Reset the timer to avoid multiple triggers
                timer = 0.0f;
            }
        }
        else
        { 
            timer = 0.0f;
        }
        lastPosition = ball.transform.position;
    }

    void OnStationary()
    {
        failureScreen.SetActive(true);
    }
}

