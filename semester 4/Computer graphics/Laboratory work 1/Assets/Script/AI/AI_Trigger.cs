using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class AI_Trigger : MonoBehaviour
{
    public GameObject Player;
    public bool isPlayer = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") 
        {
            isPlayer = true;
            Player = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isPlayer = false;
        }
    }
}
