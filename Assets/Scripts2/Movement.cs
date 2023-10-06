using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    // testing out new input system that cam showed us
    public GameObject[] Players;
    private int PlayerIndex = 0; 
    public float rotationSpeed = 350f;
    public GameObject indicator;
    
    void Start()
    {
        ActivateCurrentObject();
    }

    void Update()
    {
        float verticalInput = InputSystem.GetDevice<Keyboard>().rightArrowKey.isPressed ? 1f : InputSystem.GetDevice<Keyboard>().leftArrowKey.isPressed ? -1f : 0f;
        float rotationInput = Input.GetAxis("Vertical");
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;
        
        //horizontal movement 
        if (InputSystem.GetDevice<Keyboard>().upArrowKey.isPressed)
        {
            Players[PlayerIndex].transform.Rotate(Vector3.forward, rotationAmount);
        }
        if (InputSystem.GetDevice<Keyboard>().downArrowKey.isPressed)
        {
          Players[PlayerIndex].transform.Rotate(Vector3.forward, rotationAmount);
        }
        
        //vertical rotation
        if (InputSystem.GetDevice<Keyboard>().leftArrowKey.isPressed)
        {
            MoveCurrentObjectOnZ(verticalInput);
        }
        if (InputSystem.GetDevice<Keyboard>().rightArrowKey.isPressed)
        {
           MoveCurrentObjectOnZ(verticalInput);
        }
        
        //switch players button
        if (InputSystem.GetDevice<Keyboard>().enterKey.wasPressedThisFrame)
        {
            ToggleObject();
        }
    }
    
    // Move player object left to right
    void MoveCurrentObjectOnZ(float verticalInput)
    {
        if (PlayerIndex >= 0 && PlayerIndex < Players.Length)
        {
            Vector3 currentPosition = Players[PlayerIndex].transform.position;
            float newZPosition = Mathf.Clamp(currentPosition.z + verticalInput * 0.01f, -1.5f, 1.5f);
            Players[PlayerIndex].transform.position = new Vector3(
                currentPosition.x,
                currentPosition.y,
                newZPosition
            );
        }
    }
    
    // Switch players
    void ToggleObject()
    {
        indicator.SetActive(false);
        PlayerIndex = (PlayerIndex + 1) % Players.Length;
        ActivateCurrentObject();
    }
    
    // Move indicator to the current object
    void MoveIndicatorToCurrentObject()
    {
        if (PlayerIndex >= 0 && PlayerIndex < Players.Length)
        {
            indicator.transform.SetParent(Players[PlayerIndex].transform);
            indicator.transform.localPosition = Vector3.zero;
            indicator.SetActive(true);
        }
    }

    // Activate the current object
    void ActivateCurrentObject()
    {
        MoveIndicatorToCurrentObject();
    }

    
}