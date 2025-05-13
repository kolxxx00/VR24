using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Box : MonoBehaviour
{
    public Conveier checker;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Det"))
        {
            checker._isMoving = false;
        }
    }
}
