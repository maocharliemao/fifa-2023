using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceOff : MonoBehaviour
{
    public float repelForce = 100.0f;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();

        if (rb != null)
        {
            Vector3 repelDirection = transform.position - other.transform.position;
            repelDirection.Normalize();
            rb.AddForce(repelDirection * repelForce, ForceMode.Impulse);
        }
    }
}





