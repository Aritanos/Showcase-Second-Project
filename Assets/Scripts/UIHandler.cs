using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private MenuPanel _menuPanel;

    private void Awake()
    {
        GameStateHandler.Subscribe(GlobalGameEvent.Start, SetMenuDisabled);
        GameStateHandler.Subscribe(GlobalGameEvent.Finish, SetMenuEnabled);
    }

    public void SetMenuEnabled()
    {
        _menuPanel.Enable();
    }

    private void SetMenuDisabled()
    {
        _menuPanel.Disable();
    }
}