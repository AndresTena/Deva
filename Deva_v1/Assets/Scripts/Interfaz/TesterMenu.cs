using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TesterMenu : MonoBehaviour
{
    public GameObject  menu, informeMenu, mainMenu, historialMenu;
    bool actMainMenu, actInformeMenu, actReset, actHistorialMenu;
    static bool change = false;
    public PestanasMenu pestanas;

    public void Update()
    {
        change = pestanas.animacionDerecha.GetBool("changeState");
        if (menu.gameObject.activeSelf && change)
        {
            pestanas.abrirPestanas();
            pestanas.animacionDerecha.SetBool("changeState", false);
            pestanas.animacionIzquierda.SetBool("changeState", false);
        }
        if (actMainMenu)
        {
            if (change)
            {
                mainMenu.gameObject.SetActive(true);
                menu.gameObject.SetActive(false);
                actMainMenu = false;
            }
        }
        else if (actInformeMenu)
        {
            if (change)
            {
                informeMenu.gameObject.SetActive(true);
                menu.gameObject.SetActive(false);
                actInformeMenu = false;
            }
        }
        else if (actHistorialMenu)
        {
            if (change)
            {
                historialMenu.gameObject.SetActive(true);
                menu.gameObject.SetActive(false);
                actHistorialMenu = false;
            }
        }
        else if (actReset)
        {
            GameState.gameState.decision = "";
            GameState.gameState.currentQ = 0;
            GameState.gameState.currentSession = -1;
            GameState.gameState.love = 0;
            GameState.gameState.sadness = 0;
            GameState.gameState.hatred = 0;
            GameState.gameState.stability = 0;
            GameState.gameState.neutral = 0;
            GameState.gameState.firstTime = true;
            if (change)
            {
                SceneManager.LoadScene("deva_menu");
            }
        }
    }

    public void activeMainMenu()
    {
        actMainMenu = true;
    }

    public void activeInformeMenu()
    {
        actInformeMenu = true;
    }

    public void activeHistorialMenu()
    {
        actHistorialMenu = true;
    }

    public void QuitGame()
    {
        actReset = true;
        Debug.Log("¡Quit!");
        Application.Quit();
    }
}
