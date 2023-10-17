using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    public CarModel carModel;

    void Update()
    {
        // Get keyboard input using the InputSystem
        Keyboard keyboard = InputSystem.GetDevice<Keyboard>();

        // Horizontal movement
        if (keyboard.wKey.isPressed)
        {
            carModel.horizontalInput = 1f;
        }
        else if (keyboard.sKey.isPressed)
        {
            carModel.horizontalInput = -1f;
        }
        else
        {
            carModel.horizontalInput = 0f;
        }

        // Vertical rotation
        if (keyboard.aKey.isPressed)
        {
            carModel.verticalInput = -1f;
        }
        else if (keyboard.dKey.isPressed)
        {
            carModel.verticalInput = 1f;
        }
        else
        {
            carModel.verticalInput = 0f;
        }
    }
}
        

    


