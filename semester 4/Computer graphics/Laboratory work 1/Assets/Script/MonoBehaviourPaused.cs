using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class MonoBehaviourPaused : MonoBehaviour
{
    bool isPaused = GameInfo.isPaused;
    private void Update()
    {
        if (!GameInfo.isPaused)
            _Update();
        _UpdateNonPaused();
    }
    private void FixedUpdate()
    {
        if(isPaused != GameInfo.isPaused)
        {
            isPaused = GameInfo.isPaused;
            if(isPaused)
                _Pause();
            else
                _Play();
        }
        if (!GameInfo.isPaused)
            _FixedUpdate();
        _FixedUpdateNonPaused();
    }
    protected virtual void _Update() { }
    protected virtual void _FixedUpdate() { }
    protected virtual void _UpdateNonPaused() { }
    protected virtual void _FixedUpdateNonPaused() { }
    protected virtual void _Play() { }
    protected virtual void _Pause() { }
}
