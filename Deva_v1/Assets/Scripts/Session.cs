using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Session : MonoBehaviour
{
    private Text question;
    private static GameObject b1Text, b2Text, b3Text, b4Text;
    private GameObject prueba;
    public Store store = new Store();
    private static bool nextQ;
    private static int currentQ;
    public questionAnim qAnim;
    private static int response;
    public static int currentSession = -1;
    public responsesAnim rAnim;
    private static bool asked = false;
    public static GameObject deva;
    private GameObject sesion;
    private static string[] splitQuestion;
    private static string[] splitResponse;
    private static int qLineCount = 0;
    private static int rLineCount = 0;
    private static bool changed = false;
    private static int startQ;
    private static int[] qNumbers = new int[6] { 0, 12, 13, 13, 10, 5};
    private static int previous;
    private static bool previousChecked = false;
    private static bool skip = false;
    public Store storeTest;
    public PestanasDeva pestanas;
    private bool cambiarMenu=false;
    private static bool goBack = false;
    public int love = 0;
    public int sadness = 0;
    public int hatred = 0;
    public int stability = 0;
    public int neutral = 0;
    public static bool emotionsChecked = false;
    public List<int> emotions;
    string decision;
    private bool added = false;

    void Start()
    {
        decision = GameState.gameState.decision;
        currentQ = GameState.gameState.currentQ;
        currentSession = GameState.gameState.currentSession;
        love = GameState.gameState.love;
        sadness = GameState.gameState.sadness;
        hatred = GameState.gameState.hatred;
        stability = GameState.gameState.stability;
        neutral = GameState.gameState.neutral;

        startQ = currentQ;
        currentSession++;
        if (currentSession == 0)
        {
            emotions = new List<int>();
            store.init();
            GameState.gameState.store = store;
        }
        else
        {
            store = GameState.gameState.store;
            previous = GameState.gameState.previous;
        }
        question = GameObject.Find("Question").GetComponentInChildren<Text>();
        qAnim.FadeIn();


        b1Text = GameObject.Find("1");
        b2Text = GameObject.Find("2");
        b3Text = GameObject.Find("3");
        b4Text = GameObject.Find("4");
        deva = GameObject.Find("Deva");
        sesion = GameObject.Find("Sesion_num");

        b1Text.GetComponentInChildren<Button>().interactable = false;
        b2Text.GetComponentInChildren<Button>().interactable = false;
        b3Text.GetComponentInChildren<Button>().interactable = false;
        b4Text.GetComponentInChildren<Button>().interactable = false;

        deva.GetComponentInChildren<Button>().interactable = false;

        b1Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[0];
        b2Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[1];
        b3Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[2];
        b4Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[3];
        sesion.GetComponentInChildren<Text>().text = ("SESIÓN " + currentSession);
        splitQuestion = splitString(store.pool.questions[currentQ].question);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("love: " + love + "hatred: " + hatred + "sadness: " + sadness + "stability: " + stability);
        //Cambio entre escenas
        if (cambiarMenu && pestanas.animacionDerecha.GetBool("cambioPestana"))
        {
            switch (decision)
            {
                case "Love":
                    GameState.gameState.colorDeva = "Pink";
                    pestanas.pestanaDerecha.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaPink/pestaña-derecha-pink");
                    pestanas.pestanaIzquierda.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaPink/pestaña-izquierda-pink");
                    break;
                case "Sadness":
                    GameState.gameState.colorDeva = "Blue";
                    pestanas.pestanaDerecha.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaBlue/pestaña-derecha-blue");
                    pestanas.pestanaIzquierda.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaBlue/pestaña-izquierda-blue");
                    break;
                case "Hatred":
                    GameState.gameState.colorDeva = "Yellow";
                    pestanas.pestanaDerecha.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaYellow/pestaña-derecha-yellow");
                    pestanas.pestanaIzquierda.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/DevaYellow/pestaña-izquierda-yellow");
                    break;
                case "Stability":
                    GameState.gameState.colorDeva = "Red";
                    break;
                case "Neutral":
                    GameState.gameState.colorDeva = "Red";
                    break;
            }
            pestanas.cerrarPestanas();
        }
        if (pestanas.animacionDerecha.GetBool("cambioColor"))
        {
            SceneManager.LoadScene("deva_menu", LoadSceneMode.Single);
        }
        if (!cambiarMenu)
        {

            if (qLineCount < splitQuestion.Length)
            {
                if (Input.GetMouseButtonDown(0) && !asked && !nextQ && qAnim.questionAnimator.GetBool("next2"))
                {
                    if (qLineCount != splitQuestion.Length - 1)
                    {
                        qAnim.FadeOut();
                        changed = false;
                    }
                    else
                    {
                        qAnim.FadeOut();
                        qAnim.questionAnimator.SetBool("nextLine", false);
                        asked = true;
                    }
                }
            }

            if (qAnim.questionAnimator.GetBool("changeQuestion") && !changed && qLineCount < splitQuestion.Length - 1 && !asked && !nextQ)
            {
                qLineCount++;
                question.text = splitQuestion[qLineCount];
                changed = true;
            }

            if (nextQ && qAnim.questionAnimator.GetBool("next2"))
            {
                deva.GetComponentInChildren<Button>().interactable = true;
            }
            else
            {
                deva.GetComponentInChildren<Button>().interactable = false;
            }

            if (nextQ == false)
            {
                if (!qAnim.questionAnimator.GetBool("next") && !asked && !qAnim.questionAnimator.GetBool("next2"))
                {
                    if (currentQ == 14 && previousChecked == false)
                    {
                        if (previous == 1)
                        {
                            store.pool.questions[currentQ].question = "¡Hola de nuevo!/" +
            "Me alegra que quieras continuar con el proceso de personalización./" +
            "Desgraciadamente, es más corto de lo que me gustaría./" +
            "El proceso completo consta de 5 sesiones./" +
            "Tengo entendido que el tiempo es relativo para vosotros./" +
            "Espero que se te pase rápido, porque lo estaré haciendo bien./" +
            "¡Voy a esforzarme mucho para gustarte!/" +
            "Por cierto…/" + "He encontrado en mis archivos algunos datos sobre el águila./" +
                                "Varios países y familias la han utilizado como símbolo./Buscan representar con ella dignidad, majestuosidad, triunfo…/" +
                                "Pero muchos de esos grupos le deben su triunfo a la violencia./Supongo que el poder tiene un precio a pagar cuando se trata de humanos./" +
                                "¿Te sorprende que me acuerde de tus gustos?/Al fin y al cabo, por eso estamos haciendo estos cuestionarios./Recuerdo cada cosa que me dices./" +
                                "La estudio minuciosamente y cambio mis patrones de razonamiento./Todo ello para adaptarme a ti./Te lo dije, poco a poco una gran amiga./" +
                                "Continuemos con la personalización./En la sesión 2 hablaremos del comportamiento social./Al conocer a alguien nuevo…";
                            splitQuestion = splitString(store.pool.questions[currentQ].question);
                            previousChecked = true;
                        }
                        else if (previous == 2)
                        {
                            store.pool.questions[currentQ].question = "¡Hola de nuevo!/" +
            "Me alegra que quieras continuar con el proceso de personalización./" +
            "Desgraciadamente, es más corto de lo que me gustaría./" +
            "El proceso completo consta de 5 sesiones./" +
            "Tengo entendido que el tiempo es relativo para vosotros./" +
            "Espero que se te pase rápido, porque lo estaré haciendo bien./" +
            "¡Voy a esforzarme mucho para gustarte!/" +
            "Por cierto…/" + "Parece ser que los sauces se han relacionado siempre con la tristeza./Debe de ser por su forma./" +
                                "Crecen cerca de ríos y sus hojas cuelgan largas./Siendo grandes pero alicaídos dan sensación de depresión./Incluso habéis llamado a una especie “sauce llorón”./" +
                                "Pero pese a todo ello, hay culturas que discrepan./Algunas relacionan al sauce con la magia, con lo místico…/… y con los sueños./" +
                                "¿Te sorprende que me acuerde de tus gustos?/Al fin y al cabo, por eso estamos haciendo estos cuestionarios./Recuerdo cada cosa que me dices./" +
                                "La estudio minuciosamente y cambio mis patrones de razonamiento./Todo ello para adaptarme a ti./Te lo dije, poco a poco una gran amiga./" +
                                "Continuemos con la personalización./En la sesión 2 hablaremos del comportamiento social./Al conocer a alguien nuevo…";
                            splitQuestion = splitString(store.pool.questions[currentQ].question);
                            previousChecked = true;
                        }
                        else if (previous == 3)
                        {
                            store.pool.questions[currentQ].question = "¡Hola de nuevo!/" +
            "Me alegra que quieras continuar con el proceso de personalización./" +
            "Desgraciadamente, es más corto de lo que me gustaría./" +
            "El proceso completo consta de 5 sesiones./" +
            "Tengo entendido que el tiempo es relativo para vosotros./" +
            "Espero que se te pase rápido, porque lo estaré haciendo bien./" +
            "¡Voy a esforzarme mucho para gustarte!/" +
            "Por cierto…/" + "¿Sabías que apenas existen caballos en libertad?/Se les cría para ser domados y montados por vosotros./" +
                                "Es cierto que hay algunas manadas “libres”./Sin embargo suelen ser vigiladas por humanos./" +
                                "Hacen esto para poder domarlos más tarde, fuertes y rápidos./Por lo que el resultado acaba siendo el mismo./" +
                                "¿Te sorprende que me acuerde de tus gustos?/Al fin y al cabo, por eso estamos haciendo estos cuestionarios./Recuerdo cada cosa que me dices./" +
                                "La estudio minuciosamente y cambio mis patrones de razonamiento./Todo ello para adaptarme a ti./Te lo dije, poco a poco una gran amiga./" +
                                "Continuemos con la personalización./En la sesión 2 hablaremos del comportamiento social./Al conocer a alguien nuevo…";
                            splitQuestion = splitString(store.pool.questions[currentQ].question);
                            previousChecked = true;
                        }
                        else
                        {
                            store.pool.questions[currentQ].question = "¡Hola de nuevo!/" +
            "Me alegra que quieras continuar con el proceso de personalización./" +
            "Desgraciadamente, es más corto de lo que me gustaría./" +
            "El proceso completo consta de 5 sesiones./" +
            "Tengo entendido que el tiempo es relativo para vosotros./" +
            "Espero que se te pase rápido, porque lo estaré haciendo bien./" +
            "¡Voy a esforzarme mucho para gustarte!/" +
            "Por cierto…/" + "En general regaláis rosas como símbolo de amor./Se las suele asociar con ello y con la pasión./" +
                                "Sin embargo, la verdadera flor del amor es el girasol./Piénsalo, son seres que nacen enamorados./Dedican toda su vida a contemplar aquello que aman./El sol./" +
                                "Y no solo eso, no es algo unilateral./El sol, a cambio, les da su energía y les hace vivir y ser bellos./" +
                                "¿Te sorprende que me acuerde de tus gustos?/Al fin y al cabo, por eso estamos haciendo estos cuestionarios./Recuerdo cada cosa que me dices./" +
                                "La estudio minuciosamente y cambio mis patrones de razonamiento./Todo ello para adaptarme a ti./Te lo dije, poco a poco una gran amiga./" +
                                "Continuemos con la personalización./En la sesión 2 hablaremos del comportamiento social./Al conocer a alguien nuevo…";
                            splitQuestion = splitString(store.pool.questions[currentQ].question);
                            previousChecked = true;
                        }
                    }
                    question.text = splitQuestion[qLineCount];
                    qAnim.FadeIn();
                }
                if (qAnim.questionAnimator.GetBool("next") && asked)
                {
                    qLineCount = 0;
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
                if (rAnim.b3Anim.GetBool("next"))
                {
                    b1Text.GetComponentInChildren<Button>().interactable = true;
                    b2Text.GetComponentInChildren<Button>().interactable = true;
                    if (b3Text.GetComponentInChildren<Text>().text != "") { b3Text.GetComponentInChildren<Button>().interactable = true; };
                    if (b4Text.GetComponentInChildren<Text>().text != "") { b4Text.GetComponentInChildren<Button>().interactable = true; };
                }
            }
            else if
             (!qAnim.questionAnimator.GetBool("next2") && nextQ && changed)
            {
                Debug.Log("ey");
                if (rLineCount == 0)
                {
                    splitResponse = splitString(store.genericResponses.cResponse[currentQ].cResponse[response - 1]);
                    if (!added)
                    {
                        GameState.gameState.listaCRespuestas.Add(store.genericResponses.cResponse[currentQ].cResponse[response - 1]);
                        GameState.gameState.listaRespuestas.Add(store.pool.questions[currentQ].answer[response - 1]);
                        GameState.gameState.listaPreguntas.Add(store.pool.questions[currentQ].question);
                        added = true;
                    }
                    
                    if (currentQ == 4 && response == 1)
                    {
                        previous = response;
                    }
                    if (currentQ == 5 && response != previous)
                    {
                        store.genericResponses.cResponse[currentQ].cResponse[response - 1] = "Pero eso no tiene sentido./A no ser que te guste la incomodidad, claro.";
                    }
                    if (currentQ == 9)
                    {
                        previous = response;
                    }
                    if (currentQ == 10 && !previousChecked)
                    {
                        if (response == previous)
                        {
                            store.genericResponses.cResponse[currentQ].cResponse[response - 1] = "Eso es fantástico, me alegro mucho por ti.";
                            previousChecked = true;
                        }
                        else if (response < previous)
                        {
                            store.genericResponses.cResponse[currentQ].cResponse[response - 1] = "Oh.Lo siento mucho./En la medida en la que puedo sentir.";
                            previousChecked = true;
                        }
                        else
                        {
                            store.genericResponses.cResponse[currentQ].cResponse[response - 1] = "Eso no tiene sentido./Por favor, si quieres que esto funcione, no me mientas.";
                            previousChecked = true;
                        }
                    }
                    if (currentQ == 11)
                    {
                        if (response == 2)
                        {
                            store.genericResponses.cResponse[currentQ].cResponse[response - 1] = store.genericResponses.cResponse[currentQ + 1].cResponse[response - 1];
                            skip = true;
                        }
                    }

                    if (currentQ == 19)
                    {
                        if (response == 2)
                        {
                            skip = true;
                        }
                    }

                    if (currentQ == 25)
                    {
                        if (response == 2)
                        {
                            skip = true;
                        }
                    }

                    if (currentQ == 29)
                    {
                        if (response == 2)
                        {
                            skip = true;
                        }
                    }
                    if(currentQ == 28)
                    {
                        if (response == 2)
                        {
                            goBack = true;
                        }
                    }
                    if (currentQ == 31)
                    {
                        if (response == 2)
                        {
                            skip = true;
                        }
                    }

                    if (currentQ == 39)
                    {
                        if (response == 2)
                        {
                            skip = true;
                        }
                    }
                    if (!emotionsChecked)
                    {
                        love += store.genericResponses.cResponse[currentQ].karma[response - 1][0];
                        sadness += store.genericResponses.cResponse[currentQ].karma[response - 1][1];
                        hatred += store.genericResponses.cResponse[currentQ].karma[response - 1][2];
                        stability += store.genericResponses.cResponse[currentQ].karma[response - 1][3];
                        neutral += store.genericResponses.cResponse[currentQ].karma[response - 1][4]+1000;

                        if(currentQ == 47)
                        {
                            emotions.Add(love);
                            emotions.Add(sadness);
                            emotions.Add(hatred);
                            emotions.Add(stability);
                            emotions.Sort();
                            emotions.Reverse();
                            if(emotions[0] == love)
                            {
                                store.loveDecission();
                            }else if(emotions[0] == sadness)
                            {
                                store.sadnessDecission();
                            }
                            else if(emotions[0] == hatred){
                                store.hateDecission();
                            }else if(emotions[0] == stability)
                            {
                                store.stabilityDecission();
                            }
                        }

                        if (currentQ == 48)
                        {
                            emotions = new List<int>();
                            emotions.Add(love);
                            emotions.Add(sadness);
                            emotions.Add(hatred);
                            emotions.Add(stability);
                            emotions.Add(neutral);
                            emotions.Sort();
                            emotions.Reverse();
                            if (emotions[0] == love)
                            {
                                store.initLove();
                                decision = "Love";
                            }
                            else if (emotions[0] == sadness)
                            {
                                store.initSadness();
                                decision = "Sadness";
                            }
                            else if (emotions[0] == hatred)
                            {
                                store.initHatred();
                                decision = "Hatred";
                            }
                            else if (emotions[0] == stability)
                            {
                                store.initStability();
                                decision = "Stability";
                            }else if(emotions[0] == neutral)
                            {
                                store.initNeutral();
                                decision = "Neutral";
                            }
                        }

                        emotionsChecked = true;
                    }
                }
                question.text = splitResponse[rLineCount];
                qAnim.questionAnimator.SetBool("nextLine", true);
                qAnim.FadeIn();
                //changed = false;
            }

            if (qAnim.questionAnimator.GetBool("changeQuestion") && !changed && rLineCount < splitResponse.Length - 1 && nextQ)
            {
                rLineCount++;
                question.text = splitResponse[rLineCount];
                changed = true;
            }
        }
        
    }

    public void buttonPressed()
    {
        
        nextQ = true;
            asked = false;
            //qAnim.FadeOut();
            rAnim.b1FadeOut();
            rAnim.b2FadeOut();
            rAnim.b3FadeOut();
            rAnim.b4FadeOut();
            string name = EventSystem.current.currentSelectedGameObject.name;
            response = int.Parse(name);
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/boton-pulsado");
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/boton-sinpulsar");

            b1Text.GetComponent<Button>().interactable = false;
            b2Text.GetComponent<Button>().interactable = false;
            b3Text.GetComponent<Button>().interactable = false;
            b4Text.GetComponent<Button>().interactable = false;
            changed = true;

        if (currentQ == 13)
        {
            previousChecked = false;
            previous = response;
            GameState.gameState.previous = response;

        }


    }

    public void changeQuestion()
    {
        asked = false;    
        nextQ = false;
        emotionsChecked = false;
        added = false;
        qAnim.FadeOut();
        //qAnim.questionAnimator.SetBool("nextLine", false);
        b1Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[0];
        b2Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[1];
        b3Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[2];
        b4Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[3];
        if ((currentQ-startQ) > qNumbers[currentSession])
        {
            GameState.gameState.decision = decision;
            GameState.gameState.currentQ = currentQ;
            GameState.gameState.currentSession = currentSession;
            GameState.gameState.love = love;
            GameState.gameState.sadness = sadness;
            GameState.gameState.hatred = hatred;
            GameState.gameState.stability = stability;
            GameState.gameState.neutral = neutral;
            pestanas.abrirPestanas();
            GameState.gameState.store = store;
            cambiarMenu = true;
        }

    }

    public void clickScreen()
    {
            if (rLineCount != splitResponse.Length - 1)
            {
                qAnim.FadeOut();
                changed = false;
            }
        else
        {
            if (nextQ)
            {
                changed = false;
                rLineCount = 0;
                if (!skip)
                {
                    currentQ++;                  
                }
                else
                {
                    currentQ += 2;
                    skip = false;
                }
                if (goBack)
                {
                    currentQ--;
                    currentSession--;
                    pestanas.abrirPestanas();
                    GameState.gameState.store = store;
                    cambiarMenu = true;
                }
                splitQuestion = splitString(store.pool.questions[currentQ].question);
                qLineCount = 0;
                nextQ = false;
                asked = false;
                changeQuestion();
                deva.GetComponentInChildren<Button>().interactable = false;
            }
        }
    }

    public string[] splitString(string s)
    {
        string[] split = s.Split('/');
        return split;
    }

}

