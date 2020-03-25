using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketShip : MonoBehaviour
{
    Rigidbody body;
    AudioSource thrutAudio;
    bool playThrsut;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        thrutAudio = GetComponent<AudioSource>();
        thrutAudio.Stop();
        playThrsut = false;
    }

    // Update is called once per frame
    void Update()
    {
        Thrust();
        Rotate();
    }

    private void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("foce up");
            body.AddRelativeForce(Vector3.up * 10);
            if (!thrutAudio.isPlaying)
                thrutAudio.Play();
        }
        else
            thrutAudio.Stop();

    }

    private void Rotate()
    {

        if (Input.GetKey(KeyCode.A))
        {
            print("counter clockwise");
            body.transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D)) 
        {
            print("clockwise");
            body.transform.Rotate(-Vector3.forward);
        }
    }
}
