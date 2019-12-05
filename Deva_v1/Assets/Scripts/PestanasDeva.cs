using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PestanasDeva : MonoBehaviour
{
    public GameObject pestanaDerecha, pestanaIzquierda;
    public Animator animacionDerecha, animacionIzquierda;
    // Start is called before the first frame update
    public void cerrarPestanas()
    {
        animacionDerecha = pestanaDerecha.GetComponent<Animator>();
        animacionIzquierda = pestanaIzquierda.GetComponent<Animator>();

        animacionDerecha.SetBool("cerrar", true);
        animacionDerecha.SetBool("abrirMas", false);
        animacionIzquierda.SetBool("cerrar", true);
        animacionIzquierda.SetBool("abrirMas", false);

    }

    public void abrirPestanas()
    {
        animacionDerecha = pestanaDerecha.GetComponent<Animator>();
        animacionIzquierda = pestanaIzquierda.GetComponent<Animator>();

        animacionDerecha.SetBool("abrirMas", true);
        animacionDerecha.SetBool("cerrar", false);
        animacionIzquierda.SetBool("abrirMas", true);
        animacionIzquierda.SetBool("cerrar", false);
    }
}
