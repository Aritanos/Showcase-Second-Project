using UnityEngine;

namespace TestProject.UISystem
{
    public class MenuAnimation : MonoBehaviour
    {
        [SerializeField] private Animator _anim;

        public void TriggerAnimation()
        {
            _anim.SetTrigger(Constants.ANIMATION_PARAM_SHOW);
        }
    }
}
