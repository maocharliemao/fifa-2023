using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeams : MonoBehaviour
{

    public TeamNames Team;
    
        public enum TeamNames
    {
        Red,
        Blue
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Team = TeamNames.Blue;
        Team = TeamNames.Red;
    }

    // Update is called once per frame
    void Update()
    {
            
    }
    
}
