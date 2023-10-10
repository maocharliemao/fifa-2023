using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public float pushForce = 10.0f;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has a Rigidbody
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Calculate the direction from this object to the colliding object
            Vector3 pushDirection = collision.transform.position - transform.position;

            // Normalize the direction vector
            pushDirection.Normalize();

            // Apply a force to push the object in the opposite direction
            rb.AddForce(pushDirection * pushForce, ForceMode.Impulse);
        }
    }

}
