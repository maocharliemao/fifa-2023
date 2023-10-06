using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameOverState : MonoBehaviour
{

    public GameObject gameOverMenu;
    public MonoBehaviour gameState;
    public StateManager stateManager;
    private void OnEnable()
    {
        gameOverMenu.SetActive(true);
    }
    
    public void Update()
    {
        
    }


    private void OnDisable()
    {
        gameOverMenu.SetActive(false);
    }

    public void MouseClick()
    {
        stateManager.ChangeState(gameState);
        SceneManager.LoadScene("SoccerGame");
    }
    
}
