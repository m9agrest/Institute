using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class RigidbodyGame : MonoBehaviourPaused
{
    [SerializeField]
    float DeadY = -5f;
    [SerializeField]
    bool Respawn = false;
    [SerializeField]
    Vector3 RespawnPosition = Vector3.zero;
    [SerializeField]
    bool Rotation = false;


    Rigidbody R;
    Transform T;
    private Vector3 _pausedVelocity;
    private Vector3 _pausedAngularVelocity;
    private void Start()
    {
        T = GetComponent<Transform>();
        R = GetComponent<Rigidbody>();
        R.freezeRotation = !Rotation;
    }
    protected override void _FixedUpdate()
    {
        if (T.position.y < DeadY)
        {
            if (Respawn)
                T.position = new Vector3(RespawnPosition.x, RespawnPosition.y, RespawnPosition.z);
            else
            {
                Debug.Log(T.position);
                Debug.Log(R.velocity);
                Destroy(gameObject);
            }
        }
    }
    protected override void _Pause()
    {
        _pausedVelocity = R.velocity;
        _pausedAngularVelocity = R.angularVelocity;
        R.isKinematic = true;
    }
    protected override void _Play()
    {
        R.isKinematic = false;
        R.velocity = _pausedVelocity;
        R.angularVelocity = _pausedAngularVelocity;
    }
}
