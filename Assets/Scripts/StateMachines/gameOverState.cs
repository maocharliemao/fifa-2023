using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameOverState : MonoBehaviour
{

    public GameObject gameOverMenu;
    public MonoBehaviour gameState;
    public StateManager stateManager;
    public GameObject gameStates;
    public StartingGameState startingGame;
    private void OnEnable()
    {
        gameOverMenu.SetActive(true);
        gameStates.SetActive(false);
      
    }
    
    public void Update()
    {
        
    }


    private void OnDisable()
    {
 
        gameStates.SetActive(false);
        startingGame.enabled = false;
    }
    

    public void MouseClick()
    {
        stateManager.ChangeState(gameState);
        SceneManager.LoadScene("SoccerGame");
    }
    
}
