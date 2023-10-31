using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFlip : MonoBehaviour
{
    public float resetCooldown = 5.0f; // Time in seconds to wait before resetting again
    private float lastResetTime = 0.0f;
    private bool canReset = true;

    public void Flip()
    {
        if (canReset && Time.time - lastResetTime >= resetCooldown)
        {
            lastResetTime = Time.time;
            Transform carTransform = transform;

            // Reset the car's Y rotation to 0
            carTransform.rotation = Quaternion.Euler(0, carTransform.rotation.eulerAngles.y, 0);

            // Set the car's Y position to 1
            carTransform.position = new Vector3(carTransform.position.x, 1, carTransform.position.z);
        }
    }
}