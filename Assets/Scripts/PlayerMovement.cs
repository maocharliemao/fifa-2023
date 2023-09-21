using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public bool kickBall;
    public Vector3 mouseReleasePosition;
    public Vector3 mousePressDownPosition;
    Rigidbody rb;
    public float forceMultiplier = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDrag()
    {
        
    }

    public void OnMouseDown()
    {
        mousePressDownPosition = Input.mousePosition;
       
    }

    public void OnMouseUp()
    {
        mouseReleasePosition = Input.mousePosition;
        Shoot(mousePressDownPosition - mouseReleasePosition);
    }

    void Shoot(Vector3 Force)
    {
        if (kickBall)
            return;

        Force.z = Force.y;
        Force.y = 0;
        
        rb.AddForce(Force * forceMultiplier);
        mousePressDownPosition = Vector3.zero;
        mouseReleasePosition = Vector3.zero;
       // kickBall = true;
    }

}
