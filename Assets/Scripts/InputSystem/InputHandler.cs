﻿using UnityEngine;

public partial class InputHandler : MonoBehaviour
{
    [SerializeField] MovementHandler _movementHandler;
    [SerializeField] MouseInputReceiver _mouseReceiver;

    private void Awake()
    {
        GameStateHandler.Subscribe(GlobalGameEvent.Start, EnableMovement);
        GameStateHandler.Subscribe(GlobalGameEvent.Finish, DisableMovement);

        _movementHandler.SetInput(_mouseReceiver);
    }

    private void EnableMovement()
    {
        _movementHandler.Enable();
    }

    private void DisableMovement()
    {
        _movementHandler.Disable();
    }
}


