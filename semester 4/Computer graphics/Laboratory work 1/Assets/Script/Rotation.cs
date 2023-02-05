using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviourPaused
{
    [SerializeField]
    float RotateInSeconds = 5.0f;
    Vector3 rotor = new Vector3(0, 0, 0);
    private void Start()
    {
        rotor = new Vector3(0, (360 / RotateInSeconds) / (1 / Time.fixedDeltaTime), 0);
    }
    protected override void _FixedUpdate()
    {
        transform.eulerAngles += rotor;
    }
}

