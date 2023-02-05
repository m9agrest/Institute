using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnityEngine;
using UnityEngine.AI;

public class AI_1 : MonoBehaviourPaused
{
    [SerializeField]
    AI_Trigger AreaVisibility;
    [SerializeField]
    AI_Trigger AreaPursuit;
    [SerializeField]
    float Speed = 1f;
    bool Action = false;
    NavMeshAgent N;
    Transform T;
    private void Start()
    {
        N = GetComponent<NavMeshAgent>();
        T = GetComponent<Transform>();
        N.speed = Speed;
    }
    protected override void _FixedUpdate()
    {
        if(AreaVisibility.isPlayer)
        {
            Action = true;
            GameInfo.TriggeredEnemy++;
        }
        if(!AreaPursuit.isPlayer)
        {
            Action = false;
            GameInfo.TriggeredEnemy--;
        }
        if(Action)
        {
            N.destination = AreaPursuit.Player.transform.position;
            T.LookAt(AreaPursuit.Player.transform.position);
            T.rotation = Quaternion.Euler(0, T.eulerAngles.y, 0);
        }
    }
}
