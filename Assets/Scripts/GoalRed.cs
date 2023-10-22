using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalRed : MonoBehaviour, IScoreable
{
    [SerializeField]
    private Referee gameManager;

    
    public void Score()
    {
        gameManager.AddScoreToRedTeam();
        Debug.Log("added red score");
    }
}
