﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PhysicsEngineScript : MonoBehaviour
{
    public Vector3 Acceleration;
    public Vector3 Velocity;
    public Vector3 ForceAccum;
    public Vector3 Gravity;
    public Rigidbody rb;
    public float InveseMass;
    public float damping;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        damping = 0.0f;
        InveseMass = 0.0f;
        Gravity = new Vector3(0, -1, 0);            
        Velocity = new Vector3 (0.0f, 0.0f, 0.0f);
        Acceleration = new Vector3(0.0f, 0.0f, 0.0f);
        rb.AddForce(Gravity * InveseMass);
        transform.position += Velocity * Time.time + (Acceleration * Time.time * 0.5f);
        //Debug.Log("make red power ranger");
        Vector3 resultingAcc = Acceleration;
        resultingAcc.Scale (ForceAccum * InveseMass);
        Velocity.Scale (resultingAcc * Time.time);
        Velocity *= (damping * Time.time);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            InveseMass = 2.0f;
            Velocity = new Vector3(0.0f, 0.0f, 35.0f);
            Acceleration = new Vector3(-1.0f, 0.0f, 0.0f);
            damping = 0.99f;
        }
    }

    
}

public class Firework : PhysicsEngineScript
{
    public float Age;
    public int MinAge;
    public int MaxAge;
    public Vector3 MinVelocity;
    public Vector3 MaxVelocity;

    void Payload()
    {
        string Type = "";
        int Count = 0;
    }
    public int PayloadCount;
    void Update()
    {
        Age = (Age - Time.deltaTime);

    }


}