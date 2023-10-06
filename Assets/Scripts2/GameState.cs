using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class GameState : MonoBehaviour
{

   public StateManager stateManager;
   public MonoBehaviour gameState;
   public Referee referee;
   public TextMeshProUGUI textMeshPro;
   public gameOverState gameOver;
   
    private void OnEnable()
    {
        referee.OnScoreChange += CheckForGameOver;
    }
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            stateManager.ChangeState(gameState);
        }
    }


    private void OnDisable()
    {
        referee.OnScoreChange -= CheckForGameOver;
    }
    
    
    
    private void CheckForGameOver(int redScore, int blueScore)
    { 
        if (redScore >= 3 || blueScore >= 3)
        {
            stateManager.ChangeState(gameOver);
            string winningTeam = (redScore >= 3) ? "Red Team" : "Blue Team";
            textMeshPro.text = winningTeam + " wins!";
        }
    }
    
    

}

