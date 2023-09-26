using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GoalScript : MonoBehaviour
{
    public ManagerGame managerGame;

    private void OnTriggerEnter(Collider other)
    {

        BallScript ballScript = other.GetComponent<BallScript>();
        
        if (ballScript != null)
        {
            ballScript.ResetBallPosition();
            Debug.Log("goal is scored");
            managerGame.GoalScored();

        }
    }
}