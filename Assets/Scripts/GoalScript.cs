using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GoalScript : MonoBehaviour
{
    public ManagerGame managerGame;
    public PlayerTeams.TeamNames team;
    public int score = 0;

    private void OnTriggerEnter(Collider other)
    {

        BallScript ballScript = other.GetComponent<BallScript>();
        
        if (ballScript != null)
        {
            if (ballScript.currentTeam == team);
        }

        score++;
        ballScript.ResetBallPosition();
        managerGame.GoalScored();
        Debug.Log("goal for team" + team + "!" + score);
    }
}