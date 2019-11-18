using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class EmailMenu : MonoBehaviour
{
    public GameObject titleObj, textobj, notification, menu;
    public PestanasMenu pestanas;
    Animator animacionDerecha, animacionIzquierda;
    TextMeshProUGUI title, text;
    TextMeshProUGUI [] botones;

    public void Update()
    {
        if (menu.gameObject.activeSelf)
        {
            pestanas.abrirPestanas();
        }

    }
   
    public void message()
    {
        notification.gameObject.SetActive(false);
        title = titleObj.GetComponent<TextMeshProUGUI>();
        text = textobj.GetComponent<TextMeshProUGUI>();
        title.gameObject.SetActive(true);
        text.gameObject.SetActive(true);

        title.text = EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<TextMeshProUGUI>()[0].text;
        text.text = EventSystem.current.currentSelectedGameObject.GetComponentsInChildren<TextMeshProUGUI>()[1].text;

    }

}
