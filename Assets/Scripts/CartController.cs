using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartController : MonoBehaviour
{
    [SerializeField] WheelCollider rightWheel;
    [SerializeField] WheelCollider leftWheel;

    [SerializeField] Transform rightWheelTransform;
    [SerializeField] Transform leftWheelTransform;

    public float acceleration = 500f;

    private float currectAcceleration;

    private float inputAcceleration;

    private void FixedUpdate()
    {
        currectAcceleration = acceleration * inputAcceleration;

        rightWheel.motorTorque = currectAcceleration;
        leftWheel.motorTorque = currectAcceleration;

        UpdateWheelTransform(leftWheel, leftWheelTransform);
        UpdateWheelTransform(rightWheel, rightWheelTransform);
    }

    public void Move(float moveVector)
    {
        inputAcceleration = moveVector;
    }

    public void ResetMove()
    {
        inputAcceleration = 0;
    }

    void UpdateWheelTransform(WheelCollider wheelCol, Transform wheelTransform)
    {
        Vector3 position;
        Quaternion rotation;
        wheelCol.GetWorldPose(out position, out rotation);

        wheelTransform.position = position;
        wheelTransform.rotation = rotation;
    }
}
