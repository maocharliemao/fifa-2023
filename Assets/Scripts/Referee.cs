using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Referee : MonoBehaviour
{
    public int redTeamScore  = 0;
    public int blueTeamScore  = 0;
    
    public GameObject ball; 
    
    public delegate void ScoreChangeEvent(int redScore, int blueScore);
    public event ScoreChangeEvent OnScoreChange;
    

    
    public delegate void GameOverEvent(int redScore, int blueScore);
    public event GameOverEvent OnGameOver;
    
    public delegate void ResetToInitial();
    public event ResetToInitial OnPlayerReset;


    private void ResetBall()
    {
       
        if (ball != null)
        {
            Debug.Log("reset ball");
            ball.transform.position = Vector3.zero; 
        }
    }
    

    public void AddScoreToRedTeam()
    {
        redTeamScore++;
        NotifyScoreChange();
        ResetBall();
        GameOver();
        PlayerResetEvent();
    }

    public void AddScoreToBlueTeam()
    {
        blueTeamScore++;
        NotifyScoreChange();
        ResetBall();
        GameOver();
        PlayerResetEvent();
    }
    
    private void NotifyScoreChange()
    {
        Debug.Log("Notify");
        OnScoreChange?.Invoke(redTeamScore, blueTeamScore);
    }

    
    private void GameOver()
    {
        Debug.Log("game over");
        OnGameOver?.Invoke(redTeamScore, blueTeamScore);
    }

    private void PlayerResetEvent()
    {
        Debug.Log("reset");
        OnPlayerReset?.Invoke();
    }
    
    
    
    

}
