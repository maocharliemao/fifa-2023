using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour, IScoreable
{
    //too ez
    public delegate void GoalScore();
    public event GoalScore ScoringEvent;
    


    public void Score()
    {
        AddScore();
    }
    
    
    
    public void AddScore()
    {
        ScoringEvent?.Invoke();
        //this should call something, maybe the Referee
    }
    
}
