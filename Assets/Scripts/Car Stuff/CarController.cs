using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class CarController : MonoBehaviour
{
    public CarModel carModel;
    public PlayerInput playerInput;

    private void Start()
    {
        playerInput.actions.FindAction("Acceleration").performed += aContext => carModel.Move(true);

        playerInput.actions.FindAction("Acceleration").canceled += aContext => carModel.Move(false);



        playerInput.actions.FindAction("Brake").performed += aContext => carModel.Break(true);

        playerInput.actions.FindAction("Brake").canceled += aContext => carModel.Break(false);


        

        playerInput.actions.FindAction("Turn").performed += OnCarTurnOnperformed;

        playerInput.actions.FindAction("Turn").canceled += OnCarTurnCanceled;
    }

    private void OnCarTurnOnperformed(InputAction.CallbackContext aContext)
    {
        if (aContext.phase == InputActionPhase.Performed)
        {
            carModel.Steer(aContext.ReadValue<Vector2>().x);
        }
    }

    private void OnCarTurnCanceled(InputAction.CallbackContext aContext)
    {
        carModel.Steer(0);
    }
}