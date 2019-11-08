using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PhysicsEngineScript : MonoBehaviour
{
    public Vector3 Acceleration;
    public Vector3 Velocity;
    public Vector3 ForceAccum;
    public Vector3 Gravity;
    public Rigidbody rb;
    public float Mass;
    float Duration;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Duration > 0.0 )
            {




            }
        
        Gravity = new Vector3(0, -1, 0);
     
        Mass = 2.0f;
        Velocity = new Vector3 (0.0f, 0.0f, 5.0f);
        Acceleration = new Vector3(0.0f, -1.0f, 0.0f);
        rb.AddForce(Gravity * Mass);
        transform.position += Velocity * Time.deltaTime + (Acceleration * Time.deltaTime * 0.5f);
        Debug.Log("make red power ranger");

        Vector3 resultingAcc = Acceleration;
        resultingAcc.Scale(ForceAccum);
        rb.AddForce(ConstantForce);
        
    }

    
}

public class Partical
{
    public Vector3 Acceleration;
    public Vector3 Velocity;
    public Vector3 ForceAccum;
    public Vector3 Gravity;
    public Rigidbody rb;
    public float Mass;
  


}