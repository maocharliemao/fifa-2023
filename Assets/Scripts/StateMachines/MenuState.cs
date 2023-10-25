using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuState : StateBases
{
    public GameObject menu;
    public StateManager stateManager;
    public StateBases gameState;
    private void OnEnable()
    {
       menu.SetActive(true);

    }


    public void FixedUpdate()
    {
    }


    private void OnDisable()
    {
        menu.SetActive(false);

    }
    
    
    public void MouseClick()
    {
       stateManager.ChangeState(gameState);
    }
    
}
