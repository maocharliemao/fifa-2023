using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Score : MonoBehaviour
{
    public TextMeshProUGUI textMeshProred;
    public Referee referee;
    public TextMeshProUGUI textMeshProblue;
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
        textMeshProred.text = "SCORE\n" + redTeamScore;
        textMeshProblue.text = "SCORE\n" + blueTeamScore;
    
    }


}
