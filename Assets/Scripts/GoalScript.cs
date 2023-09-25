using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GoalScript : MonoBehaviour
{

    public int score = 0;

    private void OnTriggerEnter(Collider other)
    {

        BallScript ballScript = other.GetComponent<BallScript>();
        
        if (ballScript != null)
        {
            score++;
            ballScript.ResetBallPosition();
        }
    }
}