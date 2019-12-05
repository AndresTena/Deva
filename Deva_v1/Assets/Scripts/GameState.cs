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
    public string decision;
    public int currentQ = 0;
    public int currentSession = -1;
    public int love,sadness,hatred,stability,neutral=0;
    public List<string> listaPreguntas;
    public List<string> listaRespuestas;
    public List<string> listaCRespuestas;
    


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
