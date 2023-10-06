using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseState : MonoBehaviour
{
    public GameObject pauseMenu;
    public MonoBehaviour gameState;
    public StateManager stateManager;
    private void OnEnable()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
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
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    

    
    
}
