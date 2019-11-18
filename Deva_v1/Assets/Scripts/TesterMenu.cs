using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesterMenu : MonoBehaviour
{
    public GameObject  menu, informeMenu;
    public PestanasMenu pestanas;

    public void Update()
    {
        if (menu.gameObject.activeSelf)
        {
            pestanas.abrirPestanas();
        }

    }
    public void QuitGame()
    {
        Debug.Log("¡Quit!");
        Application.Quit();
    }
}
