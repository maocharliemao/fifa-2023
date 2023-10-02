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

    public void ResetToInitial()
    {

        transform.position = initialPosition;
        transform.rotation = initialRotation;
    }
    
    public void Update()
    {
        //ummmmmmmmmmmmmmmmmmmmm
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            ResetToInitial();
        }
    }

}