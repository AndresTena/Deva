using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionPool
{
    public List<Question> questions = new List<Question>();
    public int currentQ = 0;

    public questionPool(List<Question> questions, int currentQ)
    {
        this.questions = questions;
        this.currentQ = currentQ;
    }

    public void addQuestion(string question, string answer1, string answer2, string answer3 = "", string answer4 = "")
    {
        List<string> respuestas = new List<string>();
        respuestas.Add(answer1);
        respuestas.Add(answer2);
        respuestas.Add(answer3);
        respuestas.Add(answer4);
        Question q = new Question(question, respuestas);
        this.questions.Add(q);
    }

}