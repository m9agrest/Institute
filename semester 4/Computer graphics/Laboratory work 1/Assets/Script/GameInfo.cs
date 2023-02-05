using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using UnityEditor;
using UnityEngine;

//[InitializeOnLoad]
public class GameInfo
{
    static public bool isBattled => TriggeredEnemy > 0;
    static public int TriggeredEnemy = 0;
    static public bool isPaused = true;
    static public int Coin = 0;
    static public int Gem = 0;
    static public float SpeedForward = 15f;
    static public float Speed = 10f;
    static public float SpeedJump = 25f;
    //static private int DayCycle = 200;
    //static private int time = 0;
    //static public int Time => time;
    // static public int DayTime => DayCycle * 2;
    //static public bool isDay => time >= 0 ? true : false;
    //static System.Timers.Timer Letimer;

    /*static GameInfo()
    {
        //Time.
        //Time.fixedDeltaTime = 0.05f;
        //Letimer = new System.Timers.Timer(100);
        //Letimer.Elapsed += timer;
        //Letimer.Start();
    }*/
    
    /*static void timer(object sender, ElapsedEventArgs e)
    {
        time += 1;
        if (time == DayCycle)
            time = -DayCycle;
    }*/
}
