using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagerGame : MonoBehaviour
{
    public int playerScore = 0;
    public int maxScore = 5;

    public BallScript ballScript;
    public Playermovement2[] playersToReset;
    public PlayerMovement[] playersToReset2;

    private void Update()
    {
        if (playerScore >= maxScore)
        {
            Debug.Log("Game Over - Player Wins!");
        }
        
    }

    public void GoalScored()
    {
        playerScore++;
        Debug.Log("Goal Scored! Player Score: " + playerScore);
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





