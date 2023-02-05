using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviourPaused
{
    Rigidbody R;
    Transform T;

    float Speed = 12.5f;
    int isGround = 0;
    bool isJump = false;


    private void Start()
    {
        R = GetComponent<Rigidbody>();
        T = GetComponent<Transform>();
    }
    protected override void _FixedUpdate()
    {
        Move();
        RotateCamera();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
            isGround++;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ground")
        {
            isGround--;
            if (isGround < 0)
                isGround = 0;
        }
    }
    private void Move()
    {
        float MoveZ = 0;
        float MoveX = 0;
        float MoveJump = 0;
        if(R.velocity.y <= 0 && isGround > 0)
            isJump = false;
        if(isGround > 0 && !isJump)
        {
            if (Input.GetKey(Setting.Control.Key.Right))
                MoveX += GameInfo.Speed;
            if (Input.GetKey(Setting.Control.Key.Left))
                MoveX -= GameInfo.Speed;
            if (Input.GetKey(Setting.Control.Key.Backward))
                MoveZ -= GameInfo.Speed;
            if (Input.GetKey(Setting.Control.Key.Forward))
                if (MoveZ != 0)
                    MoveZ = 0;
                else if(MoveX != 0)
                    MoveZ += GameInfo.Speed;
                else
                    MoveZ += GameInfo.SpeedForward;
            if (Input.GetKey(Setting.Control.Key.Jump))
            {
                MoveJump = GameInfo.SpeedJump * GameInfo.Speed;
                if(MoveX > 0)
                    MoveX += GameInfo.SpeedJump;
                if (MoveX < 0)
                    MoveX -= GameInfo.SpeedJump;
                if (MoveZ > 0)
                    MoveZ += GameInfo.SpeedJump;
                if (MoveZ < 0)
                    MoveZ -= GameInfo.SpeedJump;
                isJump = true;
            }
        }
        R.AddForce(Quaternion.Euler(0, GetComponent<Transform>().eulerAngles.y, 0) * new Vector3(MoveX, MoveJump, MoveZ));
    }
    private void RotateCamera()
    {
        if(!Cursor.visible)
        {
            T.RotateAround(T.position, T.up,
                Input.GetAxis("Mouse X") * Setting.Control.Mouse.SpeedX * (Setting.Control.Mouse.InversionX ? -1 : 1));
            /*T.RotateAround(T.position, T.right,
                Input.GetAxis("Mouse Y") * Setting.Control.Mouse.SpeedY * (Setting.Control.Mouse.InversionY ? -1 : 1)));*/
        }
    }
}
