using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_Controller : MonoBehaviour
{
  
    void Update()
    {
        SpaceShip.LeverVector.x = Input.GetAxis("Horizontal");
        SpaceShip.LeverVector.y = Input.GetAxis("Vertical");
    }
}
