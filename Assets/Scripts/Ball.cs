using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public void OnCollisionEnter(Collision other)
    {
        IScoreable scoreable = other.transform.GetComponent<IScoreable>();
        if (scoreable != null)
        {
            scoreable.Score();
        }
    }
}







    
    

