using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Detail : MonoBehaviour
{
    public Animator animator_;
    private GameObject detail;
    public GameObject trolley;
    public float _speed = 1.0f;
    public bool _isMoving = false;
    private bool isAnim;

    void Update()
    {
        if (_isMoving)
        {
            StartCoroutine(MoveTrolleyForSeconds(4f));
            detail.transform.position = gameObject.transform.position;
            detail.transform.rotation = gameObject.transform.rotation;
            trolley.transform.Translate(Vector3.left * Time.deltaTime * _speed);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Det"))
        {
            detail = other.gameObject;
            _isMoving = true;
            isAnim = true;
        }
    }
    IEnumerator MoveTrolleyForSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        _isMoving = false;
        if (isAnim)
        {
            animator_.SetTrigger("Go");
            isAnim = false;
        }
    }
}