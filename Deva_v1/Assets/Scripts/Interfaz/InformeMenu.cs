using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InformeMenu : MonoBehaviour
{
    public GameObject mensajePos1, mensajePos2, mensajePos3, mensajePos4, mensajePos5, notification, menu, testerMenu;
    public PestanasMenu pestanas;
    static bool change = false;
    bool actTesterMenu;
    bool error1send, error2send, error3send, error4send, error5send, error6send = false;
    string title, asunto, text;

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

    public void sendInf()
    {
        string nameErr = EventSystem.current.currentSelectedGameObject.name;

        switch (nameErr)
        {
            case "Informe1Button":
                if (!error1send)
                {
                    error1send = true;
                    title = "NeoDeo Std";
                    asunto = "Informe de errores.";
                    text = "Tras revisar los módulos de lenguaje de su versión de la aplicación no hemos percibido ninguna anomalía relevante. Probablemente se trate de algo relacionado con su propia personalidad, a la cual Deva se está adaptando. Le rogamos que tenga paciencia y si le desagrada esa clase de actitud evite dar respuestas relacionadas con la falta de modales.\n\n\nSiga testeando feliz, atentamente:\n\n\nNeoDeo Std.";
                    Mensaje mensaje = new Mensaje(title,asunto,text);
                    GameState.gameState.bandejaEmail.Add(mensaje);
                    updateEmail(mensaje.titulo, mensaje.asunto, mensaje.text);
                }
                break;
            case "Informe2Button":
                if (!error2send)
                {
                    error2send = true;
                    title = "NeoDeo Std";
                    asunto = "Informe de errores.";
                    text = "Estamos bastante seguros de que el error reportado respecto a la interfaz es algo puntual que no le impide un uso funcional para el resto de la aplicación. Por favor, siga testeando mientras nos ponemos con ello.\n\n\nAtentamente,\n\n\nNeoDeo Std.";
                    Mensaje mensaje = new Mensaje(title, asunto, text);
                    GameState.gameState.bandejaEmail.Add(mensaje);
                    updateEmail(mensaje.titulo, mensaje.asunto, mensaje.text);
                }
                break;
            case "Informe3Button":
                if (!error3send)
                {
                    error3send = true;
                    title = "NeoDeo Std";
                    asunto = "Informe de errores.";
                    text = "Le informamos de que actualmente estamos revisando la lógica de su Deva personalizada. Por el momento no encontramos patrones que den como conclusión una desviación lógica. Le recomendamos que por el momento se deje llevar por los desvaríos que Deva pueda estar experimentando, a algún lado llevarán. La vida es un conjunto de cosas sin sentido, no sea una persona aburrida y de una oportunidad a la pobre Deva, se está esforzando mucho.\n\n\nAtentamente,\n\n\nNeoDeo Std.";
                    Mensaje mensaje = new Mensaje(title, asunto, text);
                    GameState.gameState.bandejaEmail.Add(mensaje);
                    updateEmail(mensaje.titulo, mensaje.asunto, mensaje.text);
                }
                break;
            case "Informe4Button":
                if (!error4send)
                {
                    error4send = true;
                    title = "NeoDeo Std";
                    asunto = "Informe de errores.";
                    text = "Le informamos de que el departamento de buenos modales está investigando su caso específico. Sin embargo, señalan que la manera de comportarse de Deva está ligada a cómo le responde usted en las sesiones, por lo que el jefe del departamento quiere que le diga (y cito textualmente) “quien se pica, ajos come”. Le animamos, pues, a no dar respuestas en las sesiones que no quiera que le den a usted.\n\n\nAtentamente,\n\n\nNeoDeo Std.";
                    Mensaje mensaje = new Mensaje(title, asunto, text);
                    GameState.gameState.bandejaEmail.Add(mensaje);
                    updateEmail(mensaje.titulo, mensaje.asunto, mensaje.text);
                }
                break;
            case "Informe5Button":
                if (!error5send)
                {
                    error5send = true;
                    title = "NeoDeo Std";
                    asunto = "Informe de errores.";
                    text = "Gracias por continuar testeando e informar de incidencias. Seguiremos su caso con especial interés. Aún así, le animamos a continuar usando la aplicación, quizá con el paso del tiempo la personalización se ajuste más a lo que usted desea.\n\n\nAtentamente,\n\n\nNeoDeo Std.";
                    Mensaje mensaje = new Mensaje(title, asunto, text);
                    GameState.gameState.bandejaEmail.Add(mensaje);
                    updateEmail(mensaje.titulo, mensaje.asunto, mensaje.text);
                }
                break;
            case "Informe6Button":
                if (!error6send)
                {
                    error6send = true;
                    title = "NeoDeo Std";
                    asunto = "Informe de errores.";
                    text = "Es probable que por algún motivo externo a usted, el botón implementado en la interfaz esté dando algún problema. No se preocupe, en caso de que así sea y desee usted reiniciar la aplicación, le mandamos en este mensaje un botón de reseteo blindado al que solo usted puede acceder desde este mensaje.\n\n\nGracias por seguir testeando,\n\n\nNeoDeo Std.";
                    Mensaje mensaje = new Mensaje(title, asunto, text);
                    GameState.gameState.bandejaEmail.Add(mensaje);
                    updateEmail(mensaje.titulo, mensaje.asunto, mensaje.text);
                }
                break;
        }

        
    }

    public void updateEmail(string title,string asunto,string text)
    {
        if (mensajePos1.GetComponentsInChildren<Text>()[0].text == "")
        {
            mensajePos1.gameObject.SetActive(true);
            notification.gameObject.SetActive(true);
            updatePos1(title,asunto, text);
        }
        else if(mensajePos2.GetComponentsInChildren<Text>()[0].text == "")
        {
            mensajePos2.gameObject.SetActive(true);
            notification.gameObject.SetActive(true);
            updatePos2();
            updatePos1(title,asunto, text);
        }
        else if (mensajePos3.GetComponentsInChildren<Text>()[0].text == "")
        {
            mensajePos3.gameObject.SetActive(true);
            notification.gameObject.SetActive(true);
            updatePos3();
            updatePos2();
            updatePos1(title,asunto, text);
        }
        else if (mensajePos4.GetComponentsInChildren<Text>()[0].text == "")
        {
            mensajePos4.gameObject.SetActive(true);
            notification.gameObject.SetActive(true);
            updatePos4();
            updatePos3();
            updatePos2();
            updatePos1(title,asunto, text);
        }
        else 
        {
            mensajePos5.gameObject.SetActive(true);
            notification.gameObject.SetActive(true);
            updatePos5();
            updatePos4();
            updatePos3();
            updatePos2();
            updatePos1(title,asunto, text);
        }

    }

    public void updatePos1(string title, string asunto, string text)
    {
        mensajePos1.GetComponentsInChildren<Text>()[0].text = title;
        mensajePos1.GetComponentsInChildren<Text>()[1].text = asunto;
        mensajePos1.GetComponentsInChildren<Text>()[2].text = text;
    }

    public void updatePos2()
    {
        mensajePos2.GetComponentsInChildren<Text>()[0].text = mensajePos1.GetComponentsInChildren<Text>()[0].text;
        mensajePos2.GetComponentsInChildren<Text>()[1].text = mensajePos1.GetComponentsInChildren<Text>()[1].text;
        mensajePos2.GetComponentsInChildren<Text>()[2].text = mensajePos1.GetComponentsInChildren<Text>()[2].text;
    }

    public void updatePos3()
    {
        mensajePos3.GetComponentsInChildren<Text>()[0].text = mensajePos2.GetComponentsInChildren<Text>()[0].text;
        mensajePos3.GetComponentsInChildren<Text>()[1].text = mensajePos2.GetComponentsInChildren<Text>()[1].text;
        mensajePos3.GetComponentsInChildren<Text>()[2].text = mensajePos2.GetComponentsInChildren<Text>()[2].text;
    }

    public void updatePos4()
    {
        mensajePos4.GetComponentsInChildren<Text>()[0].text = mensajePos3.GetComponentsInChildren<Text>()[0].text;
        mensajePos4.GetComponentsInChildren<Text>()[1].text = mensajePos3.GetComponentsInChildren<Text>()[1].text;
        mensajePos4.GetComponentsInChildren<Text>()[2].text = mensajePos3.GetComponentsInChildren<Text>()[2].text;
    }

    public void updatePos5()
    {
        mensajePos5.GetComponentsInChildren<Text>()[0].text = mensajePos4.GetComponentsInChildren<Text>()[0].text;
        mensajePos5.GetComponentsInChildren<Text>()[1].text = mensajePos4.GetComponentsInChildren<Text>()[1].text;
        mensajePos5.GetComponentsInChildren<Text>()[2].text = mensajePos4.GetComponentsInChildren<Text>()[2].text;
    }

    /*public void updatePos6()
    {
        mensajePos6.GetComponentsInChildren<Text>()[0].text = mensajePos5.GetComponentsInChildren<Text>()[0].text;
        mensajePos6.GetComponentsInChildren<Text>()[1].text = mensajePos5.GetComponentsInChildren<Text>()[1].text;
    }*/

}
