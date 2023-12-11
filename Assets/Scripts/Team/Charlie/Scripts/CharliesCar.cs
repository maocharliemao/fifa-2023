using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Charlie
{
    [SelectionBase]
    public class CharliesCar : MonoBehaviour
    {
        public Vector3 worldVelocity;
        public Vector3 localVelocity;
        public Vector3 localDirection;
        public Vector3 forwardDirection;
        public float speed;
        public Vector3 direction;
        public float brakeForce = 2500.0f;
        public Vector3 forwardForce;
        public float turnSpeed = 0.8f;
        public GameObject TurnFrontLeftWeels;
        public GameObject TurnFrontRightWeels;
        public Rigidbody rb;
        public float turning;

        public bool canAccelerate;
        public bool CanBrake;

        // Start is called before the first frame update


        private void FixedUpdate()
        {
            rb.AddRelativeForce(-localVelocity.x * 3000, 0, 0);

            // transform.Rotate(0, turnSpeed * 3f, 0);

            TurnFrontLeftWeels.transform.localRotation = Quaternion.Euler(0, turnSpeed * turning, 0);
            TurnFrontRightWeels.transform.localRotation = Quaternion.Euler(0, turnSpeed * turning, 0);


            if (canAccelerate)
            {
                {
                    rb.AddRelativeForce(0, 0, 10000f);
                }


                if (forwardForce.z < 25f)
                {
                    forwardForce.z += 1 * Time.deltaTime;
                }
            }

            if (CanBrake)
            {
                {
                    rb.AddRelativeForce(0, 0, -7500f);
                }
                if (forwardForce.z > 25f)
                {
                    forwardForce.z -= 1 * Time.deltaTime;
                }
            }

            worldVelocity = rb.velocity;
            forwardDirection = transform.forward;
            localVelocity = transform.InverseTransformVector(worldVelocity);
            localDirection = transform.InverseTransformDirection(worldVelocity);
            speed = worldVelocity.magnitude;
            direction = worldVelocity.normalized;
        }


        public void Steer(float steerAngle)
        {
            turning = steerAngle;
        }

        public void Move(bool boolean)
        {
            canAccelerate = boolean;
        }

        public void Break(bool boolean)
        {
            CanBrake = boolean;
        }
    }
}