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
    
    [SerializeField] private float TorqueSpeed ;
    
    


    private void FixedUpdate()
    {
        rigidbody.AddRelativeTorque(new Vector3(0, LeverVector.x * RotationSpeed, 0), ForceMode.Force);
        rigidbody.AddRelativeForce(new Vector3(0, 0, LeverVector.y * MoveSpeed), ForceMode.Force);
        
        
        var turnDir = LeverVector.normalized;
        rigidbody.AddTorque(Vector3.up * turnDir.x * TorqueSpeed * -1 *rigidbody.mass);

        var right = new Vector3(transform.right.x, 0f, transform.right.z);
        rigidbody.AddTorque(right * turnDir.y * TorqueSpeed  * rigidbody.mass);
    }

    public void ChangeAltitude(float percentage) => Debug.Log(percentage);
    
    
}