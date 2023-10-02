using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class GoalScript : MonoBehaviour
{
    
    public delegate void SimpleDelegate();
    public event SimpleDelegate ScoreEvent;


    
    public void gameScore()
    {
        ScoreEvent?.Invoke();

    }
    
    
}