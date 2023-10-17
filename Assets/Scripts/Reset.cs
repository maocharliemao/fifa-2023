using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    
    public Vector3 initialPosition;
    public Quaternion initialRotation;
    public Referee referee;
    
    private void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }
    
    
    private void OnEnable()
    {
        referee.OnPlayerReset += ResetToInitial;
    }

    private void OnDisable()
    {
        referee.OnPlayerReset -= ResetToInitial;
    }
    
    
    public void ResetToInitial()
    {

        transform.position = initialPosition;
        transform.rotation = initialRotation;

    }
    
    
    
    
}