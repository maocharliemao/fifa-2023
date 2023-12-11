using System.Collections;
using System.Collections.Generic;
using Charlie;
using UnityEngine;
using UnityEngine.InputSystem;

public class Referee : MonoBehaviour
{
    public int redTeamScore = 0;
    public int blueTeamScore = 0;

    public GameObject ball;

    
    public GameObject TaxiPrefab;
    public GameObject DororianPrefab;
    public PlayerInputManager PlayerInputManager;
    public GameObject cameraPrefab;
    public Transform[] spawnPoints;
    public List<Charlie.CarModel> players;
    
    public delegate void ScoreChangeEvent(int redScore, int blueScore);

    public event ScoreChangeEvent OnScoreChange;


    public delegate void GameOverEvent(int redScore, int blueScore);

    public event GameOverEvent OnGameOver;

    public delegate void ResetToInitial();

    public event ResetToInitial OnPlayerReset;

    
    public void Awake()
    {
        if (PlayerInputManager != null) PlayerInputManager.onPlayerJoined += PlayerInputManagerOnonPlayerJoined;
    }

    private void PlayerInputManagerOnonPlayerJoined(PlayerInput aObj)
    {
        GameObject newCameraGo = Instantiate(cameraPrefab);

        aObj.camera = newCameraGo.GetComponent<Camera>();
        newCameraGo.GetComponent<CameraTracker>().target = aObj.transform;

        if (spawnPoints.Length > 0)
        {
            aObj.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
        }

        players.Add(aObj.gameObject.GetComponent<Charlie.CarModel>());
    }
    
    
    

    private void ResetBall()
    {
        if (ball != null)
        {
            Debug.Log("Resetting the ball");
            ball.transform.position = Vector3.zero;

            Rigidbody rb = ball.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
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