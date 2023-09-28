using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{

    public ManagerGame managerGame;
    public PlayerTeams.TeamNames team;
    public int score = 0;
    public TextMeshProUGUI textMeshPro;
    public GoalScript goalScript;
    public GameObject otherGameObject;


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
        BallScript ballScript = otherGameObject.GetComponent<BallScript>();
        
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
