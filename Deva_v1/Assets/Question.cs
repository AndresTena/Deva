using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question
{
    public string question;
    public List<string> answer = new List<string>();

    public Question(string question, List<string> answer)
    {
        this.question = question;
        this.answer = answer;
    }


}
