using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels : MonoBehaviour
{
    // Start is called before the first frame update

    private float lift = 10f;
    private float tyreRadius = 0.37f;
    public Rigidbody rb;
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        // Container for useful info coming from casting functions (note ‘out’ below)
        RaycastHit hitinfo;
        
        Physics.Raycast(transform.position, -transform.up, out hitinfo, tyreRadius, Int32.MaxValue, QueryTriggerInteraction.Ignore);

        // Debug: Only draw line if we hit something
        if (hitinfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitinfo.point, Color.green);
            rb.AddForce(0, lift, 0);
        }
    }
}
