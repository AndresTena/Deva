using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Session : MonoBehaviour
{
    private Text question;
    private GameObject b1Text, b2Text, b3Text, b4Text;
    private GameObject prueba;
    private Store store = new Store();
    private static bool nextQ;
    private static int currentQ = 0;
    public questionAnim qAnim;
    private static int response;
    public int currentSession = 0;
    public responsesAnim rAnim;
    private static bool asked = false;
    public GameObject deva;
    private GameObject sesion;
    public PestanasMenu pestanas;
    static bool change = false;
    bool sceneMenu = false;

    void Start()
    {
        currentSession++;
        store.init();
        question = GameObject.Find("Question").GetComponentInChildren<Text>();
        qAnim.FadeIn();


        b1Text = GameObject.Find("1");
        b2Text = GameObject.Find("2");
        b3Text = GameObject.Find("3");
        b4Text = GameObject.Find("4");
        deva = GameObject.Find("Deva");
        sesion = GameObject.Find("Sesion_num");


        b1Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[0];
        b2Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[1];
        b3Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[2];
        b4Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[3];
        sesion.GetComponentInChildren<Text>().text = ("SESION " + currentSession);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(asked);

        if (Input.GetMouseButtonDown(0) && !asked && !nextQ)
        {
            asked = true;
        }

        if (nextQ == false)
        {
            if (!qAnim.questionAnimator.GetBool("next") && !asked)
            {
                question.text = store.pool.questions[currentQ].question;
                qAnim.FadeIn();
            }
            if (qAnim.questionAnimator.GetBool("next") && asked)
            {
                qAnim.FadeOut();
                rAnim.b1FadeIn();
                
            }
            if (rAnim.b1Anim.GetBool("next"))
            {
                rAnim.b4FadeIn();
            }
            if (rAnim.b4Anim.GetBool("next"))
            {
                rAnim.b2FadeIn();
            }
            if (rAnim.b2Anim.GetBool("next"))
            {
                rAnim.b3FadeIn();
            }
        }
        else if
         (!qAnim.questionAnimator.GetBool("next") && nextQ)
        {
                question.text = store.genericResponses.cResponse[currentQ].cResponse[response-1];
                qAnim.FadeIn();
            asked = false;
        }

        change = pestanas.animacionDerecha.GetBool("changeState");
        if (change)
        {
            if (sceneMenu)
            {
                SceneManager.LoadScene("deva_menu", LoadSceneMode.Single);
            }
        }

    }

    public void buttonPressed()
    {
        nextQ = true;
        asked = false;
        qAnim.FadeOut();
        rAnim.b1FadeOut();
        rAnim.b2FadeOut();
        rAnim.b3FadeOut();
        rAnim.b4FadeOut();
        string name = EventSystem.current.currentSelectedGameObject.name;
        response = int.Parse(name);
        EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/boton-pulsado");
        EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/boton-sinpulsar");
        
    }

    public void changeQuestion()
    {
        asked = false;
        currentQ++;
        nextQ = false;
        if (currentQ != 0)
        {
            qAnim.FadeOut();
        }
        b1Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[0];
        b2Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[1];
        b3Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[2];
        b4Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[3];
        if(currentQ > 1)
        {
            pestanas.cerrarPestanas();
            sceneMenu = true;
        }

    }

    public void clickScreen()
    {
        if (nextQ)
        {
            nextQ = false;
            asked = false;
            changeQuestion();
        }
    }

}

