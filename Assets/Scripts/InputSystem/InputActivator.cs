using UnityEngine;

namespace TestProject.InputSystem
{
    public class InputActivator : MonoBehaviour
    {
        [SerializeField] private MovementHandler _movementHandler;
        [SerializeField] private InputReceiver _mouseReceiver;

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
}



