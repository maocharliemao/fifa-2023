using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement2 : MonoBehaviour
{
    public bool kickBall;
    public Vector3 mouseReleasePosition;
    public Vector3 mousePressDownPosition;
    Rigidbody rb;
    public float forceMultiplier = 100f;
    private Vector3 initialPosition;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }
    
    Vector3 MouseWorldPosition() 
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.red, 5f);
            return hit.point;
        }
        return Vector3.zero;
    }
    
    public void OnMouseDown()
    {
        mousePressDownPosition = MouseWorldPosition();
       
    }

    public void OnMouseUp()
    {
        mouseReleasePosition = MouseWorldPosition();
        Shoot(mousePressDownPosition - mouseReleasePosition);
    }
    
    void Shoot(Vector3 Force)
    {
        if (kickBall)
            return;
        
        rb.AddForce(Force * forceMultiplier);
        mousePressDownPosition = Vector3.zero;
        mouseReleasePosition = Vector3.zero;
       // kickBall = true;
    }
    
    public void ResetPlayerPosition()
    {
        transform.position = initialPosition;
    }
    
}