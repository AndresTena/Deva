using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMenu : MonoBehaviour
{
    public GameObject mainMenu,clickMenu;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mainMenu.gameObject.SetActive(true);
            clickMenu.gameObject.SetActive(false);
        }
    }
}
