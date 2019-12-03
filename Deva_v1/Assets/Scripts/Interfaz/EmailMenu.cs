using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class EmailMenu : MonoBehaviour
{
    public GameObject titleObj, textObj, asuntoObj, notification, menu, mainMenuState, resetFinal, scapeFinal, devaButton, thanksText;
    public InformeMenu informeMenu;
    public PestanasMenu pestanas;
    Animator animacionDerecha, animacionIzquierda;
    bool mainMenu;
    static bool change = false;
    string titleText, asuntoText, textText;
    Text title,asunto, text;
    Text[] botones;
    Mensaje mensaje;

    private void Start()
    {
        if (GameState.gameState.bandejaEmail.Count<=0)
        {
            titleText = "NeoDeo Std";
            asuntoText = "Cordial bienvenida.";
            textText = "Le damos la bienvenida a la versión de prueba de Deva. El equipo de NeoDeo Std le está muy agradecido por su voluntariado para ejercer de tester en nuestro último proyecto. Como ya sabrá, Deva es una inteligencia artificial en desarrollo programada para adaptarse a cada usuario, satisfaciendo sus necesidades sociales y ofreciendo apoyo emocional en caso necesario.Deva analizará sus preocupaciones, inquietudes, conductas sociales y personalidad a través de 5 sesiones en las que se tratarán distintos campos de la psique humana. Al finalizar este proceso, Deva adoptará una forma de ser idílica para usted y podrá considerarla una amiga perfecta.En caso de que note usted que la aplicación presenta anomalías le rogamos que utilice el laboratorio de testeo como mejor crea conveniente.\n\n\nEsperamos que su experiencia con Deva sea agradable y satisfactoria, atentamente:\n\n\nNeoDeo Std.";
            mensaje = new Mensaje(titleText, asuntoText, textText);
            GameState.gameState.bandejaEmail.Add(mensaje);
            informeMenu.updateEmail(mensaje.titulo, mensaje.asunto, mensaje.text);

            titleText = "NeoDeo Std";
            asuntoText = "Primeros pasos.";
            textText = "En esta versión de prueba dispone usted de 3 pantallas principales a las que acceder desde el menú principal; ordenadas de izquierda a derecha dispone de:\n\nLa bandeja de entrada, en la cual se encuentra ahora mismo. Aquí le llegarán notificaciones pertinentes relacionadas con su experiencia de uso.\n\nDeva, siendo la pantalla principal de la aplicación.Aquí entrará a la sala de Deva, donde ella conversará con usted y le hará pasar por el proceso de personalización. Es importante que recuerde que sigue siendo una versión de prueba y que usted está testeando la aplicación, esté pendiente de errores.\n\nEl laboratorio de testeo, donde encontrará tres herramientas útiles relacionadas con su tarea. La primera de ellas es el informe de errores, donde podrá reportar anomalías en la aplicación.A continuación dispone de el historial de sesiones, en caso de que quiera repasar sus conversaciones previas con Deva. Por último, el botón de reseteo.Este botón debe ser pulsado únicamente en caso de extrema necesidad, pues reinicia la aplicación entera borrando toda la memoria de Deva y el historial de general.\n\n\nEsperamos que tenga un feliz testeo, atentamente:\n\n\nNeoDeo Std.";
            mensaje = new Mensaje(titleText, asuntoText, textText);
            GameState.gameState.bandejaEmail.Add(mensaje);
            informeMenu.updateEmail(mensaje.titulo, mensaje.asunto, mensaje.text);
        }
        else
        {
            for(int i = 0; i < GameState.gameState.bandejaEmail.Count; i++)
            { 
                mensaje=GameState.gameState.bandejaEmail[i];
                informeMenu.updateEmail(mensaje.titulo, mensaje.asunto, mensaje.text);
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
        if (mainMenu)
        {
            if (change)
            {
                mainMenuState.gameObject.SetActive(true);
                menu.gameObject.SetActive(false);
                mainMenu = false;
            }
        }

    }

    public void activeMainMenu()
    {
        mainMenu = true;
    }

    public void message()
    {
        notification.gameObject.SetActive(false);
        title = titleObj.GetComponent<Text>();
        asunto = asuntoObj.GetComponent<Text>();
        text = textObj.GetComponent<Text>();
        title.gameObject.SetActive(true);
        asunto.gameObject.SetActive(true);
        text.gameObject.SetActive(true);

        title.text = EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<Text>()[0].text;
        asunto.text = EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<Text>()[1].text;
        text.text = EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<Text>()[2].text;
        if (EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<Text>()[0].text == "ResetDeva")
        {
            resetFinal.gameObject.SetActive(true);
        }
        else
        {
            resetFinal.gameObject.SetActive(false);
        }
        if (EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<Text>()[0].text == "ScapeDeva")
        {
            scapeFinal.gameObject.SetActive(true);
        }
        else
        {
            scapeFinal.gameObject.SetActive(false);
        }

    }

    public void endDeva()
    {
        mainMenu = true;
        devaButton.gameObject.SetActive(false);
        thanksText.gameObject.SetActive(true);
    }

}
