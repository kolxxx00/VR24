using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject trolley;
    public bool _isMoving = false;
    public float _speed = 1.0f;

    private void Update()
    {
        if (_isMoving)
        {
            StartCoroutine(MoveTrolleyForSeconds(4f));
            trolley.transform.Translate(Vector3.right * Time.deltaTime * _speed);
        }
    }
    private void OnMouseDown()
    {
        _isMoving = true;
    }
    IEnumerator MoveTrolleyForSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        _isMoving = false;
    }
}
