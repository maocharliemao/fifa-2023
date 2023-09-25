using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceOff : MonoBehaviour
{
    public float repelForce = 10.0f;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Calculate the direction from the object to the center of the repel area
            Vector3 repelDirection = transform.position - other.transform.position;

            // Normalize the direction vector
            repelDirection.Normalize();

            // Apply repel force to the object
            rb.AddForce(repelDirection * repelForce, ForceMode.Impulse);
        }
    }
}





