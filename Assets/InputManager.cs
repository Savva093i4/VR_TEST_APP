using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class InputManager : MonoBehaviour
{
    public static InputType inputType { get; private set; } = InputType.PC;

    public Camera PC_Camera;

    private void Start()
    {
        List<XRDisplaySubsystem> displaySubsystems = new List<XRDisplaySubsystem>();


        SubsystemManager.GetInstances(displaySubsystems);
        if (displaySubsystems.Count > 0)
        {
            Debug.Log("VR");
            PC_Camera.gameObject.SetActive(false);
            inputType = InputType.VR;
        }
    }
}

public enum InputType
{
    PC,
    VR,
}