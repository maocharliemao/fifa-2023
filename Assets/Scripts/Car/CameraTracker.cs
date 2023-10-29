using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    public Transform target;            
    public float smoothSpeed = 0.125f;  
    public Vector3 offset = new Vector3(0f, 2f, -5f);  

    void LateUpdate()
    {
        if (target == null)
        {
            return; 
        }


        Quaternion desiredRotation = target.rotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, smoothSpeed * Time.deltaTime);
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
    }
}