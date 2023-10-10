using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public float flipForce = 1000f;  // Force to flip the car
    public float maxAngle = 60f;     // Maximum angle to consider the car as flipped
    public Transform centerOfMass;   // Center of mass for better physics simulation

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (centerOfMass != null)
        {
            rb.centerOfMass = centerOfMass.localPosition;
        }
    }

    private void Update()
    {
        if (IsCarFlipped())
        {
            FlipCar();
        }
    }

    private bool IsCarFlipped()
    {
        // Cast rays downward to check if the car is flipped
        RaycastHit hit;
        Vector3 down = transform.TransformDirection(Vector3.down);

        if (Physics.Raycast(transform.position, down, out hit, 1f))
        {
            float angle = Vector3.Angle(hit.normal, Vector3.up);
            return angle > maxAngle;
        }

        return false;
    }

    private void FlipCar()
    {
        // Apply force to flip the car
        rb.AddForce(Vector3.up * flipForce, ForceMode.Impulse);
    }
}