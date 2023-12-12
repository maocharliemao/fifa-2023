using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float countdownTime = 90.0f; 
    public StateManager stateManager;
    public gameOverState gameOver;
    private void Start()
    {
        StartCoroutine(StartCountdown());
    }

    private IEnumerator StartCountdown()
    {
        while (countdownTime > 0)
        {
            textMeshPro.text = string.Format("{0}:{1:00}", Mathf.FloorToInt(countdownTime / 60), Mathf.FloorToInt(countdownTime % 60));
            countdownTime -= Time.deltaTime;
            yield return null; 
        }
        textMeshPro.text  = "Time's up!";
        stateManager.ChangeState(gameOver);
    }
}


