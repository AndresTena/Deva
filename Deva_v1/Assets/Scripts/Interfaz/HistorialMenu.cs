using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HistorialMenu : MonoBehaviour
{
    public GameObject menu, testerMenu;
    public PestanasMenu pestanas;
    static bool change = false;
    bool actTesterMenu;

    public void Update()
    {
        change = pestanas.animacionDerecha.GetBool("changeState");
        if (menu.gameObject.activeSelf && change)
        {
            pestanas.abrirPestanas();
            pestanas.animacionDerecha.SetBool("changeState", false);
            pestanas.animacionIzquierda.SetBool("changeState", false);
        }
        if (actTesterMenu)
        {
            if (change)
            {
                testerMenu.gameObject.SetActive(true);
                menu.gameObject.SetActive(false);
                actTesterMenu = false;
            }
        }
       
    }


    public void activeTesterMenu()
    {
        actTesterMenu = true;
    }

}