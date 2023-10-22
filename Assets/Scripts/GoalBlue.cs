using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBlue : MonoBehaviour, IScoreable
{
    [SerializeField]
    private Referee gameManager;
    

    public void Score()
    {
        gameManager.AddScoreToBlueTeam();
        Debug.Log("added blue score");
    }
}
