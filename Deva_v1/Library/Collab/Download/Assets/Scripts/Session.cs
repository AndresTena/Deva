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
    private int currentQ = -1;
    public questionAnim qAnim;
    private static int response;
    public int currentSession = -1;
    public responsesAnim rAnim;

    void Start()
    {
        store.init();
        question = GameObject.Find("Question").GetComponentInChildren<Text>();
        qAnim.FadeIn();


        b1Text = GameObject.Find("1");
        b2Text = GameObject.Find("2");
        b3Text = GameObject.Find("3");
        b4Text = GameObject.Find("4");
        if (currentQ == -1) { question.text = store.pool.questions[0].question; }


        changeQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(nextQ);
        if (nextQ && Input.GetMouseButtonDown(0))
        {
            changeQuestion();
        }

        if (nextQ == false)
        {
            if (!qAnim.questionAnimator.GetBool("next"))
            {
                question.text = store.pool.questions[currentQ].question;
                qAnim.FadeIn();
            }
            if (qAnim.questionAnimator.GetBool("next"))
            {
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
        }else if(!qAnim.questionAnimator.GetBool("next") && nextQ)
        {
            qAnim.FadeIn();
            nextQ = false;
        }

    }

    public void buttonPressed()
    {
        nextQ = true;
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
        currentQ++;
        if (currentQ != 0)
        {
            qAnim.FadeOut();
        }
        b1Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[0];
        b2Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[1];
        b3Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[2];
        b4Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[3];

    }

}

