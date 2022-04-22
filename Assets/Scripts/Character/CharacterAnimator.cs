using UnityEngine;

namespace TestProject
{
    public class CharacterAnimator : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        public void SetRunningAnimation()
        {
            _animator.SetBool(Constants.ANIMATION_PARAM_MOVING, true);
        }

        public void SetIdleAnimation()
        {
            _animator.SetBool(Constants.ANIMATION_PARAM_MOVING, false);
        }
    }
}

