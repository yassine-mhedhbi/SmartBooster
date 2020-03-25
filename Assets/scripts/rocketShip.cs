using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketShip : MonoBehaviour
{
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("foce up");
            body.AddRelativeForce(Vector3.up * 10);
        }
    }
}
