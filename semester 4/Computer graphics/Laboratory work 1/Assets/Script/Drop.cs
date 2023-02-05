using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    [SerializeField]
    DropType DropType = DropType.Coin;
    [SerializeField]
    int Count = 1;

    AudioSource source;
    private void Start()
    {
        source= GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            float volume = Setting.Audio.VolumeSound;
            switch(DropType)
            {
                case DropType.Coin:
                    volume *= Setting.Audio.VolumeSoundCoinPickUp;
                    GameInfo.Coin += Count;
                    break;
                case DropType.Gem:
                    volume *= Setting.Audio.VolumeSoundGemPickUp;
                    GameInfo.Gem += Count;
                    break;
            }
            Count = 0;
            AudioSource.PlayClipAtPoint(source.clip, GetComponent<Transform>().position, volume);
            Destroy(gameObject);
        }
    }
}
