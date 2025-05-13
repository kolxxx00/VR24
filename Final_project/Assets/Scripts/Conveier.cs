using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Conveier : MonoBehaviour
{
    public Catch CatchScript;
    private GameObject detail;
    public GameObject ConveierBelt;
    
    public float _speed = 0.2f;
    private bool OnConveier = false;
    [NonSerialized]
    public bool inFinish = false;
    [NonSerialized]
    public bool _isMoving = false;
    void Update()
    {
        if (OnConveier)
        {
            if (_isMoving)
            {
                detail.transform.Translate(Vector3.left * Time.deltaTime * _speed);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Det"))
        {
            detail = other.gameObject;
            CatchScript.Catched = false;
            OnConveier = true;
            detail.transform.position = ConveierBelt.transform.position;
            detail.transform.rotation = ConveierBelt.transform.rotation;
            StartCoroutine(StartMovingAfterDelay(2f));
        }
    }
    IEnumerator StartMovingAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        _isMoving = true;
    }
}
