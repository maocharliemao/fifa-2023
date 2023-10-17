using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Rigidbody rb;
    private Vector3 initialPosition; 
    public Referee referee;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }
    
    //ball resets 
    private void OnEnable()
    {
        referee.BallEvent += BallToReset;
    }

    private void OnDisable()
    {
        referee.BallEvent -= BallToReset;
    }
    
    public void BallToReset()
    {
        transform.position = initialPosition;
        Rigidbody ballRigidbody = GetComponent<Rigidbody>();
        ballRigidbody.velocity = Vector3.zero;
        ballRigidbody.angularVelocity = Vector3.zero;
    }

    public void OnCollisionEnter(Collision other)
    {
        IScoreable scoreable = other.transform.GetComponent<IScoreable>();
        if (scoreable != null)
        {
            scoreable.Score();
        }
    }
}







    
    

