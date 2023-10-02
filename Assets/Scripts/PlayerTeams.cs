using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeams : MonoBehaviour
{
    public TeamNames Team;
    public int PlayerID; 

    public enum TeamNames
    {
        Red,
        Blue
    }

   
    void Start()
    {
        
        PlayerID = Random.Range(1, 3); 
    }
    
}
