using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    public Referee referee;
    public Rigidbody rb;
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
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

    }
    
}