using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagerGame : MonoBehaviour
{
    public BallScript ballScript;
    public Playermovement2[] playersToReset;
    public PlayerMovement[] playersToReset2;

    
    public void GoalScored()
    {
        ballScript.ResetBallPosition();
        ResetAllPlayers();
    }
    
    
    
    
    private void ResetAllPlayers()
    {
        foreach (Playermovement2 player in playersToReset)
        {
            if (player != null)
            {
                player.ResetPlayerPosition();
            }
        }

        foreach (PlayerMovement player in playersToReset2)
        {
            if (player != null)
            {
                player.ResetPlayerPosition();
            }
        }
    }
}





