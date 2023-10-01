using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Referee : MonoBehaviour
{
    // ref getting paid overtime rates
    private int redTeamScore = 0;
    private int blueTeamScore = 0;
    public Goal goal;
    public Goal goal2;
    public Ball ball;
    
    private void OnEnable()
    {
        goal.ScoringEvent += AddScoreToRedTeam;
        goal2.ScoringEvent += AddScoreToBlueTeam;
        ball.BallEvent += BallToReset;
    }

    private void OnDisable()
    {
        goal.ScoringEvent -= AddScoreToRedTeam;
        goal2.ScoringEvent -= AddScoreToBlueTeam;
        ball.BallEvent -= BallToReset;
    }

    private void AddScoreToRedTeam()
    {
        redTeamScore++;
        ball.ResetBallPitch();
        Debug.Log("Red Team Score: " + redTeamScore);
    }

    private void AddScoreToBlueTeam()
    {
        blueTeamScore++;
        ball.ResetBallPitch();
        Debug.Log("Blue Team Score: " + blueTeamScore);
    }

    private void BallToReset()
    {
        Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        ball.transform.position = ball.InitialPosition;
        ballRigidbody.velocity = Vector3.zero;
        ballRigidbody.angularVelocity = Vector3.zero;
    }
    

// do an event for the ball script and player reset part
// FIND OUT WHY THATS NOT RESETTING


}
