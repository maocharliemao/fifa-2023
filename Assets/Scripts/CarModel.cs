using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarModel : MonoBehaviour, IKickable
{

    public float moveSpeed = 10f;
    public float rotationSpeed = 100f;
    private Rigidbody rb;
    public float horizontalInput;
    public float verticalInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    
    public void FixedUpdate()
    {
        // Apply movement and rotation to the car
        Vector3 movement = transform.forward * (horizontalInput * moveSpeed * Time.deltaTime);
        Quaternion rotation = Quaternion.Euler(0f, verticalInput * rotationSpeed * Time.deltaTime, 0f);

        rb.MovePosition(rb.position + movement);
        rb.MoveRotation(rb.rotation * rotation);
    }
    
    public void Kick(Vector3 kickDirection, float kickForce)
    {
        Vector3 oppositeDirection = -kickDirection.normalized;
        rb.velocity = oppositeDirection * kickForce;
        Debug.Log("Ball is kicked");
    }
    
}
