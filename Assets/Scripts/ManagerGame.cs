using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagerGame : MonoBehaviour
{
    public BallScript ballScript;
    public PlayerMovement[] playersToReset;

    
    public void GoalScored()
    {
        ballScript.ResetBallPosition();
        ResetAllPlayers();
    }
    
    
    
    
    private void ResetAllPlayers()
    {
        foreach (PlayerMovement player in playersToReset)
        {
            if (player != null)
            {
                player.ResetPlayerPosition();
            }
        }
    }
}





