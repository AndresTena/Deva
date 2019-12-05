using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PestanasMenu : MonoBehaviour
{
    public GameObject pestanaDerecha, pestanaIzquierda, reset;
    public Animator animacionDerecha,animacionIzquierda;
    public bool suicideEmotion = false;

    public void Update()
    {
        if (suicideEmotion) {
            reset.gameObject.SetActive(true);
        }
        else
        {
            reset.gameObject.SetActive(false);
        }
    } 

    public void cerrarPestanas()
    {
        animacionDerecha = pestanaDerecha.GetComponent<Animator>();
        animacionIzquierda = pestanaIzquierda.GetComponent<Animator>();
        
        animacionDerecha.SetBool("cerrar", true);
        animacionDerecha.SetBool("abrir", false);
        animacionIzquierda.SetBool("cerrar", true);
        animacionIzquierda.SetBool("abrir", false);

    }

    public void abrirPestanas()
    {
        animacionDerecha = pestanaDerecha.GetComponent<Animator>();
        animacionIzquierda = pestanaIzquierda.GetComponent<Animator>();

        animacionDerecha.SetBool("abrir", true);
        animacionDerecha.SetBool("cerrar", false);
        animacionIzquierda.SetBool("abrir", true);
        animacionIzquierda.SetBool("cerrar", false);
    }
}
