using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Score : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public Referee referee;

    private void OnEnable()
    {
        referee.OnScoreChange += DisplayScore;
    }

    private void OnDisable()
    {
        referee.OnScoreChange -= DisplayScore;
    }

    private void DisplayScore(int redTeamScore, int blueTeamScore)
    {
        textMeshPro.text = "SCORE\n" + redTeamScore + ":" + blueTeamScore;
        Debug.Log("blue "+ redTeamScore + "red " + blueTeamScore);
    }


}
