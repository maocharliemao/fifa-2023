using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public KeyCode Accelerate;
    public KeyCode Reverse;
    public KeyCode flip;

    public VehicleModel carModel;
    public CarFlip carFlip;

    public float turnSpeed = 3f;
    public KeyCode TurnLeftKey;
    public KeyCode TurnRightKey;

    private void Update()
    {
        if (Input.GetKey(Accelerate))
        {
            Debug.Log("accelreate ");
            carModel.ApplyAcceleration();
        }
        if (Input.GetKey(Reverse))
        {
            Debug.Log("reverse ");
            carModel.ApplyReverse();
        }
        if (Input.GetKey(flip))
        {
            carFlip.Flip();
        }
        

        
        float newTurnSpeed = 0f;
        if (Input.GetKey(TurnLeftKey))
        {
            Debug.Log("1 turned left");
            newTurnSpeed = -turnSpeed;
        }
        else if (Input.GetKey(TurnRightKey))
        {
            Debug.Log("1 turned right");
            newTurnSpeed = turnSpeed;
        }

        carModel.UpdateTurnSpeed(newTurnSpeed);
        
        
    }
    
}