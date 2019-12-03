using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public string colorDeva="Red";

    public static GameState gameState;

    public Store store;
    public List<Mensaje> bandejaEmail = new List<Mensaje>();

    public int previous = 0;
    public bool firstTime = true;

    public void Awake()
    {
        if (gameState == null)
        {
            gameState = this;
            DontDestroyOnLoad(gameObject);
        } else if (gameState != this)
        {
            Destroy(gameObject);
        }
    }

}
