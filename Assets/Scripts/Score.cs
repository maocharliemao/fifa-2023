using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    private ScoreUI scoreUI;
    public TextMeshProUGUI textMeshPro;
    public GoalScript goalScript;

    
    
    public void OnEnabled()
    {
        // Subscribe
        scoreUI.ScoreEvent += GoalScored;
    }

    public void OnDisabled()
    {
        // Unsubscribe
        scoreUI.ScoreEvent -= GoalScored;
    }

    public void GoalScored()
    {
        Debug.Log("goal scored");
    }

    
    
}