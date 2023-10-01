using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public delegate void ResetBall();
    public event ResetBall BallEvent;
    
    private Rigidbody rb;
    private Vector3 initialPosition; 
    public Vector3 InitialPosition { get { return initialPosition; } } // had to look this up


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    public void ResetBallPitch()
    {
        BallEvent?.Invoke();
    }

    
}
