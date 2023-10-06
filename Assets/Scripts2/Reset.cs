using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    
    public Vector3 initialPosition;
    public Quaternion initialRotation;

    private void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    
    // ReSharper disable Unity.PerformanceAnalysis
    public void ResetToInitial()
    {

        transform.position = initialPosition;
        transform.rotation = initialRotation;

    }
    
    public void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            ResetToInitial();
        }
    }

}