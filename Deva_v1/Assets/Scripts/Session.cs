using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Session : MonoBehaviour
{
    private Text question;
    private Text b1Text;
    private Text b2Text;
    private Text b3Text;
    private Text b4Text;
    private Store store = new Store();
    private bool nextQ = false;
    private int currentQ = -1;

    void Start()
    {
        store.init();
        question = GameObject.Find("Question").GetComponentInChildren<Text>();

        b1Text = GameObject.Find("Button1").GetComponentInChildren<Text>();
        b2Text = GameObject.Find("Button2").GetComponentInChildren<Text>();
        b3Text = GameObject.Find("Button3").GetComponentInChildren<Text>();
        b4Text = GameObject.Find("Button4").GetComponentInChildren<Text>();

        changeQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        if(nextQ && Input.GetMouseButtonDown(0))
        {
            changeQuestion();
        }
    }

    public void button1Pressed()
    {
        question.text = question.text + "\n" + store.genericResponses.cResponse[currentQ].cResponse[0];
        nextQ = true;
    }
    public void button2Pressed()
    {
        question.text = question.text + "\n" + store.genericResponses.cResponse[currentQ].cResponse[1];
        nextQ = true;
    }
    public void button3Pressed()
    {
        question.text = question.text + "\n" + store.genericResponses.cResponse[currentQ].cResponse[2];
        nextQ = true;
    }
    public void button4Pressed()
    {
        question.text = question.text + "\n" + store.genericResponses.cResponse[currentQ].cResponse[3];
        nextQ = true;
    }

    public void changeQuestion()
    {
        currentQ++;
        nextQ = false;
        question.text = store.pool.questions[currentQ].question;
        b1Text.text = store.pool.questions[currentQ].answer[0];
        b2Text.text = store.pool.questions[currentQ].answer[1];
        b3Text.text = store.pool.questions[currentQ].answer[2];
        b4Text.text = store.pool.questions[currentQ].answer[3];
        
    }
}
