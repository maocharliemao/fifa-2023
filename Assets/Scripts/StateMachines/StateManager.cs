using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
    
{
    public StateBases startingState;
    public StateBases currentState;
    

    private void Start()
    {
        ChangeState(startingState);
    }

    public void ChangeState(StateBases newState)
    {

        if (newState == currentState)
        {
            return;
        }
        if (currentState != null)
        {
            currentState.enabled = false;
        }

        newState.enabled = true;
        
        currentState = newState;
    }
}
