using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartA : MonoBehaviour
{
    public Animator a;

    void OnMouseDown()
    {
        a.SetTrigger("Start");
    }
}
