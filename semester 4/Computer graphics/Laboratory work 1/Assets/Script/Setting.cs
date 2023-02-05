using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting
{
    static public class Control
    {
        static public class Key
        {
            static public string Jump = "space";
            static public string Left = "a";
            static public string Right = "d";
            static public string Forward = "w";
            static public string Backward = "s";
            static public string Pause = /*"e";/*/"escape";
        }
        static public class Mouse
        {
            static public float SpeedX = 3;
            static public float SpeedY = 1;
            static public bool InversionX = false;
            static public bool InversionY = false;
        }
    }
    static public class Audio
    {

        static private float _VolumeSound = 1;
        static public float VolumeSound
        { 
            get => _VolumeSound;
            set 
            {
                if(value >= 0 && value <= 1)
                    _VolumeSound = value;
                else if(value > 1)
                    _VolumeSound = 1;
                else if (value < 0)
                    _VolumeSound = 0;
            }
        }
        static private float _VolumeSoundCoinPickUp = 1;
        static public float VolumeSoundCoinPickUp
        {
            get => _VolumeSoundCoinPickUp;
            set
            {
                if (value >= 0 && value <= 1)
                    _VolumeSoundCoinPickUp = value;
                else if (value > 1)
                    _VolumeSoundCoinPickUp = 1;
                else if (value < 0)
                    _VolumeSoundCoinPickUp = 0;
            }
        }
        static private float _VolumeSoundGemPickUp = 1;
        static public float VolumeSoundGemPickUp
        {
            get => _VolumeSoundGemPickUp;
            set
            {
                if (value >= 0 && value <= 1)
                    _VolumeSoundGemPickUp = value;
                else if (value > 1)
                    _VolumeSoundGemPickUp = 1;
                else if (value < 0)
                    _VolumeSoundGemPickUp = 0;
            }
        }
        static private float _VolumeMusic = 0f;
        static public float VolumeMusic
        {
            get => _VolumeMusic;
            set
            {
                if (value >= 0 && value <= 1)
                    _VolumeMusic = value;
                else if (value > 1)
                    _VolumeMusic = 1;
                else if (value < 0)
                    _VolumeMusic = 0;
            }
        }
    }
}
