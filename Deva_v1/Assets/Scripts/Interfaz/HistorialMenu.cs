using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HistorialMenu : MonoBehaviour
{
    public GameObject menu, testerMenu;
    public PestanasMenu pestanas;
    static bool change = false;
    public Text textoHistorial;
    bool actTesterMenu;
    string[] split;

    public void Start()
    {
        if (GameState.gameState.listaPreguntas.Count != 0 || GameState.gameState.listaRespuestas.Count != 0 || GameState.gameState.listaCRespuestas.Count != 0)
        {
            for(int i = 0; i < GameState.gameState.listaPreguntas.Count; i++)
            {
                split = splitString(GameState.gameState.listaPreguntas[i]);
                textoHistorial.text += "<b>DEVA: </b>";
                for(int j = 0; j < split.Length; j++)
                {
                    textoHistorial.text += split[j] + " ";
                }
                textoHistorial.text += "\n\n";
                split = splitString(GameState.gameState.listaRespuestas[i]);
                textoHistorial.text += "<b>TÚ: </b>";
                for (int j = 0; j < split.Length; j++)
                {
                    textoHistorial.text += split[j] + " ";
                }
                textoHistorial.text += "\n\n";
                split = splitString(GameState.gameState.listaCRespuestas[i]);
                textoHistorial.text += "<b>DEVA: </b>";
                for (int j = 0; j < split.Length; j++)
                {
                    textoHistorial.text += split[j] + " ";
                }
                textoHistorial.text += "\n\n";
            }
            
        }
        
    }

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

    public string[] splitString(string s)
    {
        string[] split = s.Split('/');
        return split;
    }

}