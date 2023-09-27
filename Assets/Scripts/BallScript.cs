using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 initialPosition;
    public PlayerTeams.TeamNames currentTeam;


 

    private void Start()
    {
         rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    public void OnTriggerEnter(Collider other)     // call player when ball touched
    {
        PlayerMovement player = other.GetComponent<PlayerMovement>();

        if (player != null)
        {
            currentTeam = player.team;

        }
        
    }

    public void ResetBallPosition()
    {
        transform.position = initialPosition;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
    
 
    
    // last team to touch the ball scores the goal
    
    
    
}


