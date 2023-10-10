using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartingGameState : MonoBehaviour
{
    
    public GameObject StartingGame;
    public StateManager stateManager;
    public MonoBehaviour gameState;
    public TextMeshProUGUI textMeshPro;
    public float countdownTime = 4.0f; 

    private void OnEnable()
    {
        StartingGame.SetActive(true); 
        StartCoroutine(StartCountdown());

    }

    private void Update()
    {

    }

    private void OnDisable()
    {
        stateManager.ChangeState(gameState);
        StartingGame.SetActive(false);
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

