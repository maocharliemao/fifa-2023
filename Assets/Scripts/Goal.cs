using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour, IScoreable
{
    public delegate void GoalScore();
    public event GoalScore ScoringEvent;
    
    
    public void Score()
    {
        AddScore();
    }
    public void AddScore()
    {
        ScoringEvent?.Invoke();
    }



}
