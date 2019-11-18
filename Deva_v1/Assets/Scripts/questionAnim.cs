using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionAnim : MonoBehaviour

{
    public GameObject question;
    public Animator questionAnimator;

   public void FadeIn()
    {
        questionAnimator = question.GetComponent<Animator>();
        questionAnimator.SetBool("fadeIn", true);
    }

    public void FadeOut()
    {
        questionAnimator = question.GetComponent<Animator>();
        questionAnimator.SetBool("fadeOut", true);
    }
}
