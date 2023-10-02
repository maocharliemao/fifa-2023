using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
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

    private void DisplayScore(int redscore, int bluescore)
    {
        textMeshPro.text = "SCORE\n" + redscore + ":" + bluescore;
    }


}
