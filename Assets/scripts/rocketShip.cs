using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketShip : MonoBehaviour
{
    [SerializeField] float rcs = 300f;
    [SerializeField] float thrust = 4f;

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
            body.AddRelativeForce(Vector3.up *thrust);
            if (!thrutAudio.isPlaying)
                thrutAudio.Play();
        }
        else
            thrutAudio.Stop();

    }

    private void Rotate()
    {
        float rotation = rcs * Time.deltaTime;
        body.freezeRotation = true;
        if (Input.GetKey(KeyCode.A))
        {   
            body.transform.Rotate(Vector3.forward * rotation);
        }
        else if (Input.GetKey(KeyCode.D)) 
        {
            body.transform.Rotate(-Vector3.forward * rotation);
        }
        body.freezeRotation = false;
    }
}
