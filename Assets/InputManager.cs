using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class InputManager : MonoBehaviour
{
    public static InputType inputType { get; private set; }

    [SerializeField] private Camera PC_Camera;
    [SerializeField] private List<GameObject> XrGO;

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
        else
        {
            Debug.Log("PC");

            foreach (var go in XrGO)
            {
                go.SetActive(false);
            }

            inputType = InputType.PC;
        }
    }
}

public enum InputType
{
    PC,
    VR,
}