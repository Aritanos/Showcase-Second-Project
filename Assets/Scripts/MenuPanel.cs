﻿using UnityEngine;
using System;

public class MenuPanel : MonoBehaviour, IEnablable
{
    [SerializeField] MenuAnimation _menuAnimation;
    
    public void StartNewLevel()
    {
        GameStateHandler.TriggerEvent(GlobalGameEvent.Start);
    }

    public void Disable()
    {
        gameObject.SetActive(false);
    }

    public void Enable()
    {
        gameObject.SetActive(true);
        _menuAnimation.TriggerAnimation();
    }

    private void OnDestroy()
    {
        GameStateHandler.UnSubscribe(GlobalGameEvent.Start, Disable);
        GameStateHandler.UnSubscribe(GlobalGameEvent.Finish, Enable);
    }
}

