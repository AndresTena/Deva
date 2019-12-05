using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject menu, testerMenu, emailMenu, informeMenu, pestanaIzq, pestanaDer, notificacion;
    public PestanasMenu pestanas;
    bool actTesterMenu, actEmailMenu, changeScene = false;
    static bool change = false;
    bool changeColor = true;
    string title, asunto, text;
    bool mensajeEnviado = false;


    public void Update()
    {
        if (GameState.gameState.decision == "Neutral" && GameState.gameState.currentQ>47 && !mensajeEnviado)
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
            title = "NeoDeo Std";
            asunto = "Informe de errores.";
            text = "Tras revisar los módulos de lenguaje de su versión de la aplicación no hemos percibido ninguna anomalía relevante. Probablemente se trate de algo relacionado con su propia personalidad, a la cual Deva se está adaptando. Le rogamos que tenga paciencia y si le desagrada esa clase de actitud evite dar respuestas relacionadas con la falta de modales.\n\n\nSiga testeando feliz, atentamente:\n\n\nNeoDeo Std.";
            Mensaje mensaje = new Mensaje(title, asunto, text);
            GameState.gameState.bandejaEmail.Add(mensaje);
            mensajeEnviado = true;
        }
        if (GameState.gameState.firstTime)
        {
            notificacion.SetActive(true);
            GameObject.Find("PlayButton").GetComponent<Button>().interactable = false;
            GameObject.Find("TesterButton").GetComponent<Button>().interactable = false;
        }
        change = pestanas.animacionDerecha.GetBool("changeState");
        if (menu.gameObject.activeSelf && change)
        {
            pestanas.abrirPestanas();
            pestanas.animacionDerecha.SetBool("changeState", false);
            pestanas.animacionIzquierda.SetBool("changeState", false);
        }
        if (actTesterMenu) { 

            if (change)
            {
                testerMenu.gameObject.SetActive(true);
                menu.gameObject.SetActive(false);
                actTesterMenu = false;
            }
        }else if (actEmailMenu)
        {
            if (change)
            {
                if (GameState.gameState.firstTime)
                {
                    GameState.gameState.firstTime = false;
                    GameObject.Find("PlayButton").GetComponent<Button>().interactable = true;
                    GameObject.Find("TesterButton").GetComponent<Button>().interactable = true;
                }
                emailMenu.gameObject.SetActive(true);
                menu.gameObject.SetActive(false);
                actEmailMenu = false;
            }
        }else if (changeScene)
        {
            if (change)
            {
                menu.gameObject.SetActive(false);
                SceneManager.LoadScene("deva_v1", LoadSceneMode.Single);
            }
        }
        if (changeColor)
        {
            switch (GameState.gameState.colorDeva){
                case "Red":
                    changeColorRed();
                    changeColor = false;
                    break;
                case "Yellow":
                    changeColorYellow();
                    changeColor = false;
                    break;
                case "Pink":
                    changeColorPink();
                    changeColor = false;
                    break;
                case "Blue":
                    changeColorBlue();
                    changeColor = false;
                    break;
            }

        }
        
    }

    public void PlayGame()
    {
        changeScene = true;
        pestanas.animacionDerecha.SetBool("changeScene", true);
        pestanas.animacionIzquierda.SetBool("changeScene", true);
    }

    public void activeTesterMenu()
    {
        actTesterMenu = true;
    }

    public void activeEmailMenu()
    {
        actEmailMenu = true;
    }


    public void changeColorYellow()
    {   //Get the animator
        Animator anim = GameObject.Find("PlayButton").GetComponent<Animator>();
        // Actually i was using "Resources" folder in assets folder. And i was loading animation by this way.
        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("AnimacionesDeva/AngryBreathing/angry-deva0004");
        GameObject.Find("PlayButton").GetComponent<Image>().sprite = Resources.Load<Sprite>("AnimacionesDeva/AngryBreathing/angry-deva0001");
        notificacion.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaYellow/notificacion-yellow");
        GameObject.Find("EmailButton").GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaYellow/bandeja-yellow");
        GameObject.Find("TesterButton").GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaYellow/tester-yellow");
        pestanaDer.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaYellow/pestaña-derecha-yellow");
        pestanaIzq.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaYellow/pestaña-izquierda-yellow");
        Button[] botonesTester=testerMenu.gameObject.GetComponentsInChildren<Button>();
        botonesTester[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaYellow/reset-yellow");
        botonesTester[1].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaYellow/historial-yellow");
        botonesTester[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaYellow/errores-yellow");
        botonesTester[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaYellow/volver-yellow");
        Button[] botonesInforme = informeMenu.gameObject.GetComponentsInChildren<Button>();
        for(int i = 0; i < botonesInforme.Length-1; i++)
        {
            botonesInforme[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaYellow/botones-error-yellow");
        }
        botonesInforme[botonesInforme.Length-1].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaYellow/volver-yellow");
        Button[] botonesEmail = emailMenu.gameObject.GetComponentsInChildren<Button>();
        botonesEmail[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaYellow/volver-yellow");
    }

    public void changeColorRed()
    {
        //Get the animator
        Animator anim = GameObject.Find("PlayButton").GetComponent<Animator>();
        // Actually i was using "Resources" folder in assets folder. And i was loading animation by this way.
        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("AnimacionesDeva/Orbiting/deva-orbiting0045");
        GameObject.Find("PlayButton").GetComponent<Image>().sprite = Resources.Load<Sprite>("AnimacionesDeva/Orbiting/deva-orbiting0001");
        notificacion.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaRed/notificacion-red");
        GameObject.Find("EmailButton").GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaRed/bandeja-red");
        GameObject.Find("TesterButton").GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaRed/tester-red");
        pestanaDer.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaRed/pestaña-derecha-red");
        pestanaIzq.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaRed/pestaña-izquierda-red");
        Button[] botonesTester = testerMenu.gameObject.GetComponentsInChildren<Button>();
        botonesTester[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaRed/reset-red");
        botonesTester[1].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaRed/historial-red");
        botonesTester[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaRed/errores-red");
        botonesTester[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaRed/volver-red");
        Button[] botonesInforme = informeMenu.gameObject.GetComponentsInChildren<Button>();
        for (int i = 0; i < botonesInforme.Length - 1; i++)
        {
            botonesInforme[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaRed/botones-error-red");
        }
        botonesInforme[botonesInforme.Length - 1].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaRed/volver-red");
        Button[] botonesEmail = emailMenu.gameObject.GetComponentsInChildren<Button>();
        botonesEmail[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaRed/volver-red");
    }

    public void changeColorPink()
    {
        //Get the animator
        Animator anim = GameObject.Find("PlayButton").GetComponent<Animator>();
        // Actually i was using "Resources" folder in assets folder. And i was loading animation by this way.
        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("AnimacionesDeva/LoveBreathing/love-deva0015");
        GameObject.Find("PlayButton").GetComponent<Image>().sprite = Resources.Load<Sprite>("AnimacionesDeva/LoveBreathing/love-deva0001");
        notificacion.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaPink/notificacion-pink");
        GameObject.Find("EmailButton").GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaPink/bandeja-pink");
        GameObject.Find("TesterButton").GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaPink/tester-pink");
        pestanaDer.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaPink/pestaña-derecha-pink");
        pestanaIzq.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaPink/pestaña-izquierda-pink");
        Button[] botonesTester = testerMenu.gameObject.GetComponentsInChildren<Button>();
        botonesTester[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaPink/reset-pink");
        botonesTester[1].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaPink/historial-pink");
        botonesTester[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaPink/errores-pink");
        botonesTester[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaPink/volver-pink");
        Button[] botonesInforme = informeMenu.gameObject.GetComponentsInChildren<Button>();
        for (int i = 0; i < botonesInforme.Length - 1; i++)
        {
            botonesInforme[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaPink/botones-error-pink");
        }
        botonesInforme[botonesInforme.Length - 1].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaPink/volver-pink");
        Button[] botonesEmail = emailMenu.gameObject.GetComponentsInChildren<Button>();
        botonesEmail[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaPink/volver-pink");
    }

    public void changeColorBlue()
    {
        //Get the animator
        Animator anim = GameObject.Find("PlayButton").GetComponent<Animator>();
        // Actually i was using "Resources" folder in assets folder. And i was loading animation by this way.
        anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("AnimacionesDeva/SadBreathing/sad-deva0065");
        GameObject.Find("PlayButton").GetComponent<Image>().sprite = Resources.Load<Sprite>("AnimacionesDeva/SadBreathing/sad-deva0001");
        notificacion.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaBlue/notificacion-blue");
        GameObject.Find("EmailButton").GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaBlue/bandeja-blue");
        GameObject.Find("TesterButton").GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaBlue/tester-blue");
        pestanaDer.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaBlue/pestaña-derecha-blue");
        pestanaIzq.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaBlue/pestaña-izquierda-blue");
        Button[] botonesTester = testerMenu.gameObject.GetComponentsInChildren<Button>();
        botonesTester[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaBlue/reset-blue");
        botonesTester[1].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaBlue/historial-blue");
        botonesTester[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaBlue/errores-blue");
        botonesTester[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaBlue/volver-blue");
        Button[] botonesInforme = informeMenu.gameObject.GetComponentsInChildren<Button>();
        for (int i = 0; i < botonesInforme.Length - 1; i++)
        {
            botonesInforme[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaBlue/botones-error-blue");
        }
        botonesInforme[botonesInforme.Length - 1].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaBlue/volver-blue");
        Button[] botonesEmail = emailMenu.gameObject.GetComponentsInChildren<Button>();
        botonesEmail[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaBlue/volver-blue");
    }
}
