using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalScore : MonoBehaviour
{

    public ManagerGame managerGame;
    public PlayerTeams.TeamNames team;
    public int score = 0;
    public TextMeshProUGUI textMeshPro;
    public GoalScript goalScript;
    public GameObject Ball;


    private void OnTriggerEnter(Collider other)
    {
        Score();
    }

    public void OnEnabled()
    {
        goalScript.ScoreEvent += Score;
    }
    

    public void OnDisabled()
    {
        goalScript.ScoreEvent -= Score;
    }
    
    private void Score()
    {
        BallScript ballScript = Ball.GetComponent<BallScript>();
        
        if (ballScript != null)
        {
           if (ballScript.currentTeam == team);
        }
        score++;
        ballScript.ResetBallPosition();
        managerGame.GoalScored();
        textMeshPro.text = ("Score" + " " + score);
        
   
    }
}
