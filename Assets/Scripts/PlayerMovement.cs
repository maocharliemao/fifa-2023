using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{

    public float Speed = 1f;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * Speed;
        float v = Input.GetAxis("Vertical") * Speed;
        Vector3 movement = new Vector3(h, 0f, h) * Speed;
        rb.AddForce(h,0,v);


    }

}
