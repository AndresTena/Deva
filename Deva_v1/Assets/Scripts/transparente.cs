using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparente : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        animator.SetBool("fadeIn", false);
        animator.SetBool("fadeOut", false);
        animator.SetBool("next", false);
    }
}
