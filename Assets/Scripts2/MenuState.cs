using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuState : MonoBehaviour
{
    public GameObject menu;
    public StateManager stateManager;
    public MonoBehaviour gameState;
    private void OnEnable()
    {
       menu.SetActive(true);
       Time.timeScale = 0;
    }


    public void FixedUpdate()
    {
    }


    private void OnDisable()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }
    
    
    public void MouseClick()
    {
       stateManager.ChangeState(gameState);
    }
    
}
