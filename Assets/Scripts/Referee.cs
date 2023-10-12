using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Referee : MonoBehaviour
{
    public int redTeamScore  = 0;
    public int blueTeamScore  = 0;
    
    public Goal goal;
    public Goal goal2;
  
    
    public delegate void ScoreChangeEvent(int redScore, int blueScore);
    public event ScoreChangeEvent OnScoreChange;
    
    public delegate void ResetBall();
    public event ResetBall BallEvent;
    
    public delegate void GameOverEvent(int redScore, int blueScore);
    public event GameOverEvent OnGameOver;
    
    public delegate void ResetToInitial();
    public event ResetToInitial OnPlayerReset;
    
    
    private void OnEnable()
    {
        goal.ScoringEvent += AddScoreToRedTeam;
        goal2.ScoringEvent += AddScoreToBlueTeam;
    }

    private void OnDisable()
    {
        goal.ScoringEvent -= AddScoreToRedTeam;
        goal2.ScoringEvent -= AddScoreToBlueTeam;
    }

    private void AddScoreToRedTeam()
    {
        redTeamScore++;
        NotifyScoreChange();
        ResetBallPitch();
        GameOver();
        PlayerResetEvent();
    }

    private void AddScoreToBlueTeam()
    {
        blueTeamScore++;
        NotifyScoreChange();
        ResetBallPitch();
        GameOver();
        PlayerResetEvent();
    }
    
    private void NotifyScoreChange()
    {
        OnScoreChange?.Invoke(redTeamScore, blueTeamScore);
    }

    private void ResetBallPitch()
    {
        BallEvent?.Invoke();
    }

    private void GameOver()
    {
        OnGameOver?.Invoke(redTeamScore, blueTeamScore);
    }

    private void PlayerResetEvent()
    {
        OnPlayerReset?.Invoke();
    }
    
    
    
    

}
