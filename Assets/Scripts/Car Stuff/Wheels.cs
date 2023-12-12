using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Charlie
{
    public class Wheels : MonoBehaviour
    {
        public Rigidbody vehicleRigidbody;
        public float tireFriction = 800f;
        public GameObject car;
        public float tireRadius;
        [Range(8000f, 21000f)] public float upForce;
        public float wheelSpeed;
        public GameObject wheel;
        public AnimationCurve springForce;
        private RaycastHit hitInfo;

        void Start()
        {
            vehicleRigidbody = GetComponentInParent<Rigidbody>();
        }

        void FixedUpdate()
        {
            Physics.Raycast(wheel.transform.position, -transform.up, out hitInfo, tireRadius, Int32.MaxValue,
                QueryTriggerInteraction.Ignore);
            if (hitInfo.collider != null)
            {
                Debug.DrawLine(transform.position, hitInfo.point, Color.red);
                var normalizedDistance = hitInfo.distance / upForce;
                vehicleRigidbody.AddForceAtPosition(transform.up * (EvaluateSpringForce(hitInfo.distance) * upForce),
                    transform.position);
                ApplyTireFriction();
            }
        }


        private void ApplyTireFriction()
        {
            wheelSpeed = vehicleRigidbody.GetPointVelocity(transform.position).magnitude;
            var localVelocity =
                transform.InverseTransformDirection(vehicleRigidbody.GetPointVelocity(transform.position));
            vehicleRigidbody.AddForceAtPosition(transform.right * (-localVelocity.x * tireFriction),
                transform.position);
        }
        
        private float EvaluateSpringForce(float position)
        {
            return springForce.Evaluate(position);
        }
    }
}