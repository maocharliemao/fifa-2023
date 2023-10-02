using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    private bool isGameOver = false;
    public TextMeshProUGUI textMeshPro;
    public Referee referee;

    void Start()
    {
        textMeshPro.gameObject.SetActive(false); 
    }

    private void OnEnable()
    {
        referee.OnScoreChange += CheckForGameOver;
    }

    private void OnDisable()
    {
        referee.OnScoreChange -= CheckForGameOver;
    }

    public void CheckForGameOver(int redScore, int blueScore)
    {
        if (!isGameOver)
        {
            if (redScore >= 3 || blueScore >= 3)
            {
                string winningTeam = (redScore >= 3) ? "Red Team" : "Blue Team";

                textMeshPro.text = winningTeam + " wins!";
                textMeshPro.gameObject.SetActive(true);

                isGameOver = true;
            }
        }
    }
}









