using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menu, testerMenu, emailMenu;
    public PestanasMenu pestanas;
    bool actTesterMenu, actEmailMenu = false;
    float tiempo = 100;

    public void Update()
    {
        if (menu.gameObject.activeSelf)
        {
            pestanas.abrirPestanas();
        }


    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void activeTesterMenu()
    {
        wait();
        testerMenu.gameObject.SetActive(true);
    }

    public void activeEmailMenu()
    {
        wait();
        emailMenu.gameObject.SetActive(true);
    }

    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(100);
    }
}
