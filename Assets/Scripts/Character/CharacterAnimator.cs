using UnityEngine;

namespace TestProject.CharacterSystem
{
    public class CharacterAnimator : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private void Start()
        {
            var mover = GetComponent<CharacterMover>();
            mover.StartMovingAction += SetRunningAnimation;
            mover.StopMovingAction += SetIdleAnimation;
        }

        public void SetRunningAnimation()
        {
            _animator.SetBool(AnimatorParameters.ANIMATION_PARAM_MOVING, true);
        }

        public void SetIdleAnimation()
        {
            _animator.SetBool(AnimatorParameters.ANIMATION_PARAM_MOVING, false);
        }
    }
}

