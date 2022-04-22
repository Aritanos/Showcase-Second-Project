using UnityEngine;
using TestProject.CharacterSystem;

namespace TestProject.InputSystem
{
    public class MovementHandler : MonoBehaviour, IEnablableAndDisablable
    {
        [SerializeField] private Character _character;

        private Vector3 _pointerPosition = Vector3.positiveInfinity;
        private IControllable _controllable => _character;

        private IInputReceiver _currentInputReceiver;

        public void SetInput(IInputReceiver receiver)
        {
            if (_currentInputReceiver == null)
            {
                _currentInputReceiver = receiver;
            }
        }

        public void Disable()
        {
            _controllable.StopMoving();
            UnSubscribeToInput(_currentInputReceiver);
        }

        public void Enable()
        {
            SubsribeToInput(_currentInputReceiver);
        }

        private void SubsribeToInput(IInputReceiver receiver)
        {
            receiver.PointerDown += OnPointerDown;
            receiver.PointerHold += OnPointerHold;
            receiver.PointerUp += OnPointerUp;
        }

        private void UnSubscribeToInput(IInputReceiver receiver)
        {

            receiver.PointerDown -= OnPointerDown;
            receiver.PointerHold -= OnPointerHold;
            receiver.PointerUp -= OnPointerUp;
        }

        private void OnPointerDown(Vector3 position)
        {
            _pointerPosition = position;
            _controllable.StartMoving();
        }

        private void OnPointerHold(Vector3 position)
        {
            var delta = position.x - _pointerPosition.x;
            _controllable.MoveSideways(delta);
            _pointerPosition = position;
        }

        private void OnPointerUp()
        {
            _pointerPosition = Vector3.positiveInfinity;
            _controllable.StopMoving();
        }
    }
}




