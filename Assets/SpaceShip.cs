using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SpaceShip : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    public static Vector2 LeverVector = new();

    [SerializeField] private float MoveSpeed = 100000;
    [SerializeField] private float RotationSpeed = 100000;


    private void FixedUpdate()
    {
        rigidbody.AddRelativeTorque(new Vector3(0, LeverVector.x * RotationSpeed, 0), ForceMode.Force);
        rigidbody.AddRelativeForce(new Vector3(0, 0, LeverVector.y * MoveSpeed), ForceMode.Force);
    }

    public void ChangeAltitude(float percentage) => Debug.Log(percentage);
}