using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    
    AudioSource A;
    [SerializeField]
    AudioClip Background;
    [SerializeField]
    AudioClip Battle;

    void Start()
    {
        A = GetComponent<AudioSource>();
        A.clip = Background;
        A.loop = true;
        FixedUpdate();
    }
    void FixedUpdate()
    {
        
        //if (GameInfo.isBattled)
            //newAudio(Battle, true);
        //else if (!GameInfo.isBattled)
            //newAudio(Background, false);
        
        if (GameInfo.isPaused && A.isPlaying)
        {
            A.Pause();
        }
        else if (!GameInfo.isPaused && !A.isPlaying)
        {
            A.volume = Setting.Audio.VolumeMusic;
            A.Play();
        }
        
    }
}
