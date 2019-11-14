using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class InformeMenu : MonoBehaviour
{
    public GameObject mensajePos1, mensajePos2, mensajePos3, mensajePos4, mensajePos5, mensajePos6, notification;
    bool error1send, error2send, error3send, error4send, error5send = false;
    string title, asunto;

    public void sendInf()
    {
        string nameErr = EventSystem.current.currentSelectedGameObject.name;

        switch (nameErr)
        {
            case "Informe1Button":
                if (!error1send)
                {
                    error1send = true;
                    title = "Lo sentimos";
                    asunto = "Disculpe las molestias y gracias por informarnos de este error itentaremos solucionarlo lo antes posible, mientras tanto siga interactuando con la aplicación de manera normal.\n Gracias por su atencion.";
                    updateEmail(title, asunto);
                }
                break;
            case "Informe2Button":
                if (!error2send)
                {
                    error2send = true;
                    updateEmail(EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<TextMeshProUGUI>()[0].text, EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<TextMeshProUGUI>()[0].text);
                }
                break;
            case "Informe3Button":
                if (!error3send)
                {
                    error3send = true;
                    updateEmail(EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<TextMeshProUGUI>()[0].text, EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<TextMeshProUGUI>()[0].text);
                }
                break;
            case "Informe4Button":
                if (!error4send)
                {
                    error4send = true;
                    updateEmail(EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<TextMeshProUGUI>()[0].text, EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<TextMeshProUGUI>()[0].text);
                }
                break;
            case "Informe5Button":
                if (!error5send)
                {
                    error5send = true;
                    updateEmail(EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<TextMeshProUGUI>()[0].text, EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<TextMeshProUGUI>()[0].text);
                }
                break;
        }

        
    }

    public void updateEmail(string title,string text)
    {
        if (mensajePos1.GetComponentsInChildren<TextMeshProUGUI>()[0].text == "")
        {
            mensajePos1.gameObject.SetActive(true);
            notification.gameObject.SetActive(true);
            updatePos1(title, text);
        }
        else if(mensajePos2.GetComponentsInChildren<TextMeshProUGUI>()[0].text == "")
        {
            mensajePos2.gameObject.SetActive(true);
            notification.gameObject.SetActive(true);
            updatePos2();
            updatePos1(title, text);
        }
        else if (mensajePos3.GetComponentsInChildren<TextMeshProUGUI>()[0].text == "")
        {
            mensajePos3.gameObject.SetActive(true);
            notification.gameObject.SetActive(true);
            updatePos3();
            updatePos2();
            updatePos1(title, text);
        }
        else if (mensajePos4.GetComponentsInChildren<TextMeshProUGUI>()[0].text == "")
        {
            mensajePos4.gameObject.SetActive(true);
            notification.gameObject.SetActive(true);
            updatePos4();
            updatePos3();
            updatePos2();
            updatePos1(title, text);
        }
        else if (mensajePos5.GetComponentsInChildren<TextMeshProUGUI>()[0].text == "")
        {
            mensajePos5.gameObject.SetActive(true);
            notification.gameObject.SetActive(true);
            updatePos5();
            updatePos4();
            updatePos3();
            updatePos2();
            updatePos1(title, text);
        }else 
        {
            mensajePos6.gameObject.SetActive(true);
            notification.gameObject.SetActive(true);
            updatePos6();
            updatePos5();
            updatePos4();
            updatePos3();
            updatePos2();
            updatePos1(title, text);
        }

    }

    public void updatePos1(string title, string text)
    {
        mensajePos1.GetComponentsInChildren<TextMeshProUGUI>()[0].text = title;
        mensajePos1.GetComponentsInChildren<TextMeshProUGUI>()[1].text = text;
    }

    public void updatePos2()
    {
        mensajePos2.GetComponentsInChildren<TextMeshProUGUI>()[0].text = mensajePos1.GetComponentsInChildren<TextMeshProUGUI>()[0].text;
        mensajePos2.GetComponentsInChildren<TextMeshProUGUI>()[1].text = mensajePos1.GetComponentsInChildren<TextMeshProUGUI>()[1].text;
    }

    public void updatePos3()
    {
        mensajePos3.GetComponentsInChildren<TextMeshProUGUI>()[0].text = mensajePos2.GetComponentsInChildren<TextMeshProUGUI>()[0].text;
        mensajePos3.GetComponentsInChildren<TextMeshProUGUI>()[1].text = mensajePos2.GetComponentsInChildren<TextMeshProUGUI>()[1].text;
    }

    public void updatePos4()
    {
        mensajePos4.GetComponentsInChildren<TextMeshProUGUI>()[0].text = mensajePos3.GetComponentsInChildren<TextMeshProUGUI>()[0].text;
        mensajePos4.GetComponentsInChildren<TextMeshProUGUI>()[1].text = mensajePos3.GetComponentsInChildren<TextMeshProUGUI>()[1].text;
    }

    public void updatePos5()
    {
        mensajePos5.GetComponentsInChildren<TextMeshProUGUI>()[0].text = mensajePos4.GetComponentsInChildren<TextMeshProUGUI>()[0].text;
        mensajePos5.GetComponentsInChildren<TextMeshProUGUI>()[1].text = mensajePos4.GetComponentsInChildren<TextMeshProUGUI>()[1].text;
    }

    public void updatePos6()
    {
        mensajePos6.GetComponentsInChildren<TextMeshProUGUI>()[0].text = mensajePos5.GetComponentsInChildren<TextMeshProUGUI>()[0].text;
        mensajePos6.GetComponentsInChildren<TextMeshProUGUI>()[1].text = mensajePos5.GetComponentsInChildren<TextMeshProUGUI>()[1].text;
    }

}
