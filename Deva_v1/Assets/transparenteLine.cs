using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparenteLine : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        animator.SetBool("fadeIn", true);
        animator.SetBool("fadeOut", false);
        animator.SetBool("next2", false);
        animator.SetBool("changeQuestion", true);
    }
}
