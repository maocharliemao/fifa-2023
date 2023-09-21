using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour


{
    public GameObject player;
    public float speed;
    public Rigidbody ball;


    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {

    }


}
