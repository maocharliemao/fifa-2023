using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalState : MonoBehaviour
{
    public GameObject goal;
    public StateManager stateManager;
    public MonoBehaviour gameState;
    public TextMeshProUGUI textMeshPro;
    
    
    private void OnEnable()
    {
        goal.SetActive(true);

    }


    public void FixedUpdate()
    {
        textMeshPro.text = ("goal is scored");
    }


    private void OnDisable()
    {
        goal.SetActive(false);

    }
    
    

}
