using UnityEngine;
using System;

namespace TestProject.CharacterSystem
{
    public class CharacterMover : MonoBehaviour, IControllable
    {
        [SerializeField] private Rigidbody _rigidBody;
        [SerializeField] private float _speed;
        [SerializeField] private float _sideMovingCoefficient;

        private Vector3 _currentMovingDirection = Vector3.zero;

        public event Action StartMovingAction;
        public event Action StopMovingAction;

        public void StartMoving()
        {
            _rigidBody.isKinematic = false;
            _currentMovingDirection.z = _speed;
            _rigidBody.velocity = _currentMovingDirection;
            StartMovingAction?.Invoke();
        }

        public void MoveSideways(float delta)
        {
            _currentMovingDirection.x = delta * _sideMovingCoefficient;
            _rigidBody.velocity = _currentMovingDirection;           
        }

        public void StopMoving()
        {
            _rigidBody.isKinematic = true;
            _currentMovingDirection = Vector3.zero;
            _rigidBody.velocity = _currentMovingDirection;
            StopMovingAction?.Invoke();
        }
    }
}


