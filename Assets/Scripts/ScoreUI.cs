using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
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
    }
    
}
