using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
//using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UI;

class PlayerUI : MonoBehaviourPaused
{
    [SerializeField]
    TextMeshProUGUI TextGem;
    [SerializeField]
    TextMeshProUGUI TextCoin;
    [SerializeField]
    GameObject MenuPaused;
    [SerializeField]
    GameObject MenuPausedSetting;

    private void Start()
    {
        UpdateText();
    }
    
    protected override void _FixedUpdateNonPaused()
    {
        UpdateText();
        if(Input.GetKeyDown(Setting.Control.Key.Pause))
        {
            Pause();
        }
        if (Input.GetMouseButtonDown(0) && GameInfo.isPaused)
            Play();
    }


    void Play()
    {
        Cursor.lockState = CursorLockMode.Locked;
        GameInfo.isPaused = false;
        Cursor.visible = false;
    }
    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        GameInfo.isPaused = true;
        Cursor.visible = true;
    }
    void UpdateText()
    {
        TextGem.text = $"Gem {GameInfo.Gem}";
        TextCoin.text = $"Coin {GameInfo.Coin}";
    }
}