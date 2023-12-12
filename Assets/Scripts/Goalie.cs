using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalie : MonoBehaviour
{
    public Transform ball;
    public float moveSpeed = 5f;
    public float kickForce = 10f;
    public float detectionRange = 2f;
    public float MinMoveDistance = -10f;
    public float MaxMoveDistance = 10f;



    void Update()
    {
        MoveGoalkeeper();
    }

    void MoveGoalkeeper()
    {
        if (ball != null)
        {
            float distanceToBall = Vector3.Distance(transform.position, ball.position);
            if (distanceToBall <= detectionRange)
            {
                Vector3 targetPosition = new Vector3(transform.position.x, Mathf.Clamp(ball.position.y, MinMoveDistance, MaxMoveDistance), transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            }

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