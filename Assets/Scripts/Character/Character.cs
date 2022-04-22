using UnityEngine;

namespace TestProject.CharacterSystem
{
    public class Character : MonoBehaviour, IControllable
    {
        [SerializeField] private Rigidbody _rb;
        [SerializeField] private CharacterAnimator _animator;
        [SerializeField] private float _speed;
        [SerializeField] private float _sideMovingCoefficient;

        private Vector3 _currentMovingDirection = Vector3.zero;

        public void StartMoving()
        {
            _rb.isKinematic = false;
            _animator.SetRunningAnimation();
            _currentMovingDirection.z = _speed;
        }

        float _currentDelta = 0;

        public void MoveSideways(float delta)
        {
            _rb.AddForce(Mathf.Lerp(_currentDelta, delta, 15) * _sideMovingCoefficient * Vector3.right, ForceMode.Acceleration);
        }

        public void StopMoving()
        {
            _rb.isKinematic = true;
            _currentMovingDirection = Vector3.zero;
            _animator.SetIdleAnimation();
        }

        private void Update()
        {
            if (_currentMovingDirection != Vector3.zero)
            {
                _rb.velocity = _currentMovingDirection;
            }
        }
    }
}


