using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartingGameState : StateBases
{
    
    public GameObject StartingGame;
    public StateManager stateManager;
    public StateBases gameState;
    public TextMeshProUGUI textMeshPro;
    public float countdownTime = 4.0f; 
    private float _initialCountdownTime;
    public GameObject gameStates;
    private void OnEnable()
    {
        StartingGame.SetActive(true); 
        gameStates.SetActive(false); 
        StartCoroutine(StartCountdown());
        _initialCountdownTime = countdownTime; 
    }

    private void Update()
    {

    }

    private void OnDisable()
    {

        StartingGame.SetActive(false);
        countdownTime = _initialCountdownTime;
        Time.timeScale = 1;
    }
    
    

    private IEnumerator StartCountdown()
    {
        while (countdownTime > 0)
        {
            textMeshPro.text = string.Format("{0}:{1:00}", Mathf.FloorToInt(countdownTime / 60), Mathf.FloorToInt(countdownTime % 60));
            countdownTime -= Time.deltaTime;
            yield return null; 
        }
        stateManager.ChangeState(gameState);
    }
    
    
    
    
}

