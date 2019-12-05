using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paradoLine : StateMachineBehaviour
{

    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        animator.SetBool("fadeIn", false);
        animator.SetBool("fadeOut", false);
        animator.SetBool("next2", true);
        animator.SetBool("changeQuestion", false);
    }
}
