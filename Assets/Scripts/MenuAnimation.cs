using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TestProject;

public class MenuAnimation : MonoBehaviour
{
    [SerializeField] private Animator _anim;

    public void TriggerAnimation()
    {
        Debug.Log("Trigger");
        _anim.SetTrigger(Constants.ANIMATION_PARAM_SHOW);
    }
}
