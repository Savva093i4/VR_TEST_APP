using System;
using System.Collections;
using System.Collections.Generic;
using BNG;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[RequireComponent(typeof(GrabbableUnityEvents))]
public class GrabeInShip : MonoBehaviour
{

    private UnityEvent onGrab;
    
    private void Start()
    {
        GetComponent<GrabbableUnityEvents>().onBecomesClosestGrabbable.AddListener(()=>Debug.Log("111"));
    }

    public bool ShouldBeStaticWhenDropedInLocalSpace = true;
}