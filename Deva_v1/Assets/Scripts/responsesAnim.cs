using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class responsesAnim : MonoBehaviour
{
    public GameObject b1, b2, b3, b4;
    public Animator b1Anim, b2Anim, b3Anim, b4Anim;

    public void b1FadeIn()
    {
        b1Anim = b1.GetComponent<Animator>();
        b1Anim.SetBool("fadeIn", true);
    }

    public void b1FadeOut()
    {
        b1Anim = b1.GetComponent<Animator>();
        b1Anim.SetBool("fadeOut", true);
    }

    public void b2FadeIn()
    {
        b2Anim = b2.GetComponent<Animator>();
        b2Anim.SetBool("fadeIn", true);
    }

    public void b2FadeOut()
    {
        b2Anim = b2.GetComponent<Animator>();
        b2Anim.SetBool("fadeOut", true);
    }

    public void b3FadeIn()
    {
        b3Anim = b3.GetComponent<Animator>();
        b3Anim.SetBool("fadeIn", true);
    }

    public void b3FadeOut()
    {
        b3Anim = b3.GetComponent<Animator>();
        b3Anim.SetBool("fadeOut", true);
    }

    public void b4FadeIn()
    {
        b4Anim = b4.GetComponent<Animator>();
        b4Anim.SetBool("fadeIn", true);
    }

    public void b4FadeOut()
    {
        b4Anim = b4.GetComponent<Animator>();
        b4Anim.SetBool("fadeOut", true);
    }
}
