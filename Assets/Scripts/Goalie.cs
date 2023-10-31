using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalie : MonoBehaviour
{
    public Transform ball;
    public float moveSpeed = 5f;
    public float kickForce = 10f;
    public float detectionRange = 2f;
    public float zMin = -10f;
    public float zMax = 10f;
    public Rigidbody rb;


    void Update()
    {
        MoveGoalkeeper();
    }

    void MoveGoalkeeper()
    {
        if (ball != null)
        {
            Vector3 targetPosition = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(ball.position.z, zMin, zMax));
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }


    



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody != null)
        {
            // Calculate the repel direction
            Vector3 repelDirection = transform.position - collision.transform.position;
            repelDirection.Normalize();

            // Apply the repel force to the collided object
            collision.rigidbody.AddForce(repelDirection * kickForce, ForceMode.Impulse);
        }
    }

}