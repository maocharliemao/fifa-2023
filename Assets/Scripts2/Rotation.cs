using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject[] objectsToControl;  
    public float rotationSpeed = 100f;     
    private int currentObjectIndex = 0;
    private bool verticalInputPressed = false;

    void Start()
    {
        ActivateCurrentObject();
    }

    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

      
        if (verticalInput != 0f && !verticalInputPressed)
        {
            verticalInputPressed = true;
            int nextObjectIndex = currentObjectIndex + (int)Mathf.Sign(verticalInput);
            nextObjectIndex = Mathf.Clamp(nextObjectIndex, 0, objectsToControl.Length - 1);
            currentObjectIndex = nextObjectIndex;
            ActivateCurrentObject();
        }
        
        if (verticalInput == 0f)
        {
            verticalInputPressed = false;
        }
        float rotationInput = Input.GetAxis("Horizontal");
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;
        objectsToControl[currentObjectIndex].transform.Rotate(Vector3.forward, rotationAmount);
    }

    void ActivateCurrentObject()
    {
        if (currentObjectIndex >= 0 && currentObjectIndex < objectsToControl.Length)
        {
            objectsToControl[currentObjectIndex].SetActive(true);
        }
    }
}