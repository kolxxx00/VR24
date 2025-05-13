using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Catch : MonoBehaviour
{
    private GameObject detail;
    [NonSerialized]
    public bool Catched = false;
    void Update()
    {
        if (Catched)
        {
            detail.transform.position = gameObject.transform.position;
            detail.transform.rotation = gameObject.transform.rotation;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Det") && !Catched)
        {
            detail = other.gameObject;
            Catched = true;
        }
    }
}