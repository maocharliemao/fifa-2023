using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingScript : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public Transform startPoint; 
    private Rigidbody rb;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        rb = startPoint.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 direction = rb.velocity.normalized;
        Vector3 endpoint = startPoint.position + direction * lineRenderer.positionCount;
        lineRenderer.SetPosition(0, startPoint.position);
        lineRenderer.SetPosition(1, endpoint);
    }
}








