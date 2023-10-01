using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRotation : MonoBehaviour
{
    // looked this movement script up because i big noob, also doesnt really matter that much, i care more about the flow of the scripts
    public GameObject[] Players;
    private int PlayerIndex = 0; 
    public float rotationSpeed = 350f;
    private bool verticalInputPressed = false;
    public GameObject indicator;

    void Start()
    {
        ActivateCurrentObject();

    }

    void Update()
    {
        float verticalInput = Input.GetAxis("Horizontal");

        if (verticalInput != 0f && !verticalInputPressed)
        {
            verticalInputPressed = true;
            MoveCurrentObjectOnZ(verticalInput);
            verticalInputPressed = false;
        }
        if (Input.GetButtonDown("Jump"))
        {
            ToggleObject();
        }

        float rotationInput = Input.GetAxis("Vertical");
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;
        Players[PlayerIndex].transform.Rotate(Vector3.forward, rotationAmount);
    }

    void ActivateCurrentObject()
    {
        if (PlayerIndex >= 0 && PlayerIndex < Players.Length)
        {
            MoveIndicatorToCurrentObject();
        }
    }

    void MoveIndicatorToCurrentObject()
    {
        if (PlayerIndex >= 0 && PlayerIndex < Players.Length)
        {
            indicator.transform.SetParent(Players[PlayerIndex].transform);
            indicator.transform.localPosition = Vector3.zero;
            indicator.SetActive(true);
        }
    }

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
    
    void ToggleObject()
    {
        indicator.SetActive(false);
        PlayerIndex = (PlayerIndex + 1) % Players.Length;
        ActivateCurrentObject();
    }


    
}