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
        ProcessInput();
    }

    private void ProcessInput()
    {
        bool prev = playThrsut; 
        if (Input.GetKey(KeyCode.Space))
        {
            print("foce up");
            body.AddRelativeForce(Vector3.up * 10);
            prev = playThrsut;
            playThrsut = true;
        }
        else 
        {
            playThrsut = false;
        }

        if (playThrsut && playThrsut != prev)
        {
            thrutAudio.Play();
        }
        else if (!playThrsut)
        {
            thrutAudio.Stop();
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("left");
            body.transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D)) 
        {
            print("Right");
            body.transform.Rotate(-Vector3.forward);
        }
    }
}
