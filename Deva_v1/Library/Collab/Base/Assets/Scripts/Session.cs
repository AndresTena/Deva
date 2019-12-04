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
    private static int currentQ = 0;
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
    private static int[] qNumbers = new int[5] { 0, 12, 11, 10, 9};
    private static int previous;
    private static bool previousChecked = false;
    private static bool skip = false;
    public Store storeTest;
    public PestanasDeva pestanas;
    private bool cambiarMenu=false;

    void Start()
    {
        startQ = currentQ;
        currentSession++;
        if (currentSession == 0)
        {
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
        //Cambio entre escenas
        if (cambiarMenu && pestanas.animacionDerecha.GetBool("cambioPestana"))
        {
            pestanas.cerrarPestanas();
        }
        if (pestanas.animacionDerecha.GetBool("cambioColor"))
        {
            SceneManager.LoadScene("deva_menu", LoadSceneMode.Single);
        }
        if (!cambiarMenu)
        {
            Debug.Log("asked: " + asked + " nextQ: " + nextQ + " next2: " + qAnim.questionAnimator.GetBool("next2") + " nextLine: " + qAnim.questionAnimator.GetBool("nextLine"));


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
        qAnim.FadeOut();
        //qAnim.questionAnimator.SetBool("nextLine", false);
        b1Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[0];
        b2Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[1];
        b3Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[2];
        b4Text.GetComponentInChildren<Text>().text = store.pool.questions[currentQ].answer[3];
        if ((currentQ-startQ) > qNumbers[currentSession])
        {
            pestanas.abrirPestanas();
            GameState.gameState.store = store;
            //Lo utilizo para compartir variables entre estados.
            //GameState.gameState.colorDeva = "Blue";
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

