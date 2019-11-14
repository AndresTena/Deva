using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store
{
    public questionPool pool = new questionPool(new List<Question>(), 0);

    public cResponseType sadResponses = new cResponseType(new List<cResponseBasic>());
    public cResponseType loveResponses = new cResponseType(new List<cResponseBasic>());
    public cResponseType genericResponses = new cResponseType(new List<cResponseBasic>());
    public cResponseType happyResponses = new cResponseType(new List<cResponseBasic>());
    public cResponseType hateResponses = new cResponseType(new List<cResponseBasic>());

    public void init()
    {
        //AQUÍ AÑADIMOS LAS PREGUNTAS
        //EJEMPLO:
        pool.addQuestion("¿Como estás?", "Bien", "Mal", "Regular", "Mejor no contesto");
        pool.addQuestion("fwefw", "xd", "Mal", "feq", "rewrewq");

        //AQUÍ AÑADIMOS LAS CONTRARRESPUESTAS
        //EJEMPLO:
        genericResponses.addResponse("Me alegro", "Vaya..", "¿Y eso?", "Vale");
        genericResponses.addResponse("xd", "ddda", "e", "213few");
    }

}
