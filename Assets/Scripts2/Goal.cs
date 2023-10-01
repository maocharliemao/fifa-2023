using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //too ez
    public delegate void GoalScore();
    public event GoalScore ScoringEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        AddScore();
        Debug.Log("Collided");
    }

    public void AddScore()
    {
        ScoringEvent?.Invoke();
        //this should call something, maybe the Referee
        Debug.Log("invoked");
    }
    
}
