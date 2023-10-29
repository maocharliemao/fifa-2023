using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public KeyCode Accelerate;
    public KeyCode Reverse;
    public KeyCode Brake;

    public VehicleModel carModel; // Reference to the MovementController script

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
        if (Input.GetKey(Brake))
        {
            Debug.Log("Break ");
            carModel.ApplyBrake();
        }
    }
}