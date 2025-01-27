using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputManager))]

public class CarController : MonoBehaviour
{
    public InputManager im;
    public List<WheelCollider> throttleWheels;
    public List<WheelCollider> steeringWheels;
    public float strengthCoefficient = 20000f;
    public float maxTurn = 20f;

    void Start()
    {
    im = GetComponent<InputManager>();
    }

   void FixedUpdate()
   {
        foreach(WheelCollider wheel in throttleWheels)
        {
            wheel.motorTorque = strengthCoefficient * Time.deltaTime * im.throttle;
        }

        foreach(WheelCollider wheel in steeringWheels)
        {
            wheel.steerAngle = maxTurn * im.steer;
        }
   }
}
