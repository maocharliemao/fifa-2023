using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public float flipForce = 1000f;  
    public float maxAngle = 60f;     
    public Transform centerOfMass;   

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
        rb.AddForce(Vector3.up * flipForce, ForceMode.Impulse);
    }
}