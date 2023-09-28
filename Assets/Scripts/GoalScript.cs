using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class GoalScript : MonoBehaviour
{
    
    public delegate void SimpleDelegate();
    
    public event SimpleDelegate ScoreEvent;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameScore();
        }
    }
    
    public void gameScore()
    {
        ScoreEvent?.Invoke();
        Debug.Log("Game Score");
    }
    
    
}