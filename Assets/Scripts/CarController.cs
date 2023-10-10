using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 100f;
    public float jumpForce = 5.0f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get keyboard input using the InputSystem
        Keyboard keyboard = InputSystem.GetDevice<Keyboard>();

        // Horizontal movement
        float horizontalInput = 0f;
        if (keyboard.wKey.isPressed)
        {
            horizontalInput = 1f;
        }
        else if (keyboard.sKey.isPressed)
        {
            horizontalInput = -1f;
        }

        // Vertical rotation
        float verticalInput = 0f;
        if (keyboard.aKey.isPressed)
        {
            verticalInput = -1f;
        }
        else if (keyboard.dKey.isPressed)
        {
            verticalInput = 1f;
        }

        // Apply movement and rotation to the car
        Vector3 movement = transform.forward * (horizontalInput * moveSpeed * Time.deltaTime);
        Quaternion rotation = Quaternion.Euler(0f, verticalInput * rotationSpeed * Time.deltaTime, 0f);

        rb.MovePosition(rb.position + movement);
        rb.MoveRotation(rb.rotation * rotation);
        
    }
    

}
