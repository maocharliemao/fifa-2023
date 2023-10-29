using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarController2 : MonoBehaviour
{
    public CarModel carModel;
    
    void Update()
    {
        // Get keyboard input using the InputSystem
        Keyboard keyboard = InputSystem.GetDevice<Keyboard>();

        // Horizontal movement
        if (keyboard.upArrowKey.isPressed)
        {
            carModel.horizontalInput = 1f;
        }
        else if (keyboard.downArrowKey.isPressed)
        {
            carModel.horizontalInput = -1f;
        }
        else
        {
            carModel.horizontalInput = 0f; 
        }

        // Vertical rotation
        if (keyboard.leftArrowKey.isPressed)
        {
            carModel.verticalInput = -1f;
        }
        else if (keyboard.rightArrowKey.isPressed)
        {
            carModel.verticalInput = 1f;
        }
        else
        {
            carModel.verticalInput = 0f; 
        }
    }
    
}
