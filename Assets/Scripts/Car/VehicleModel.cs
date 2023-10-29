using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleModel : MonoBehaviour
{
    public Vector3 worldVelocity;
    public Vector3 localVelocity;
    public Vector3 localDirection;
    public Vector3 forwardDirection;
    public float speed;
    public Vector3 direction;
    public float brakeForce = 2500.0f;
    public Vector3 forwardForce;
    public float turnSpeed;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void ApplyAcceleration()
    {
        {rb.AddRelativeForce(0,0,5000f);}

             
        if(forwardForce.z < 25f)
        {forwardForce.z += 1 * Time.deltaTime;}
    }

    public void ApplyReverse()
    {
        {rb.AddRelativeForce(0,0,-2500f);}
        if(forwardForce.z > 25f)
        {forwardForce.z -= 1 * Time.deltaTime;}
    }

    public void ApplyBrake()
    {
        Vector3 brakeVector = -rb.velocity.normalized * brakeForce;
        rb.AddForce(brakeVector);
    }
   

    private void FixedUpdate()
    {
        rb.AddRelativeForce(-localVelocity.x * 3000, 0, 0 );
        
        transform.Rotate(0, turnSpeed * 3f,0);
    }
    
    
    public void UpdateTurnSpeed(float newTurnSpeed)
    {
        turnSpeed = newTurnSpeed;
    }
    
}