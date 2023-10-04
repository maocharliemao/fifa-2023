using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameState : MonoBehaviour
{

   public StateManager stateManager;
   public MonoBehaviour gameState;
    private void OnEnable()
    {

    }
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            stateManager.ChangeState(gameState);
        }
    }


    private void OnDisable()
    {

    }


}

