using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Charlie
{
    public class CarController : MonoBehaviour
    {
        public CarModel carModel;
        public PlayerInput playerInput;

        private void Start()
        {
            playerInput.actions.FindAction("Brake").performed += aContext =>
                 Debug.Log("Break Performed");
                 carModel.Break(true);
            playerInput.actions.FindAction("Brake").canceled += aContext =>
                carModel.Break(false);
            playerInput.actions.FindAction("Acceleration").performed += aContext =>
                carModel.Move(true);
            playerInput.actions.FindAction("Acceleration").canceled += aContext =>
                carModel.Move(false);
            playerInput.actions.FindAction("Turn").performed += OnCarTurnOnperformed;
            playerInput.actions.FindAction("Turn").canceled += OnCarTurnOnperformed;
        }

        private void OnCarTurnOnperformed(InputAction.CallbackContext aContext)
        {
            if (aContext.phase == InputActionPhase.Performed)
            {
                carModel.Steer(aContext.ReadValue<Vector2>().x);
            }
            else if (aContext.phase == InputActionPhase.Canceled)
            {
                carModel.Steer(0);
            }
        }
    }
}
