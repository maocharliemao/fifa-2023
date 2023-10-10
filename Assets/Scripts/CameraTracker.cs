using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    public Transform target;            // The target to follow (assign the player object in the Inspector).
    public float smoothSpeed = 0.125f;  // Smoothing speed for camera movement.
    public Vector3 offset = new Vector3(0f, 2f, -5f);  // Camera offset from the target.

    void LateUpdate()
    {
        if (target == null)
        {
            return; // If the target is not assigned, do nothing.
        }

        // Calculate the desired rotation based on the target's rotation.
        Quaternion desiredRotation = target.rotation;

        // Apply the rotation smoothly to the camera.
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, smoothSpeed * Time.deltaTime);

        // Calculate the desired position based on the target's position and offset.
        Vector3 desiredPosition = target.position + offset;

        // Smoothly move the camera to the desired position.
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
    }
}