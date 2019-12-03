using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cResponseType
{
    public List<cResponseBasic> cResponse = new List<cResponseBasic>();

    public cResponseType(List<cResponseBasic> cResponse)
    {
        this.cResponse = cResponse;
    }

    public void addResponse(string response1, string response2, string response3 = "optional", string response4 = "optional", List<List<int>> karma = null)
    {
        List<string> responses = new List<string>();
        List<int> l = new List<int>();
        l.Add(0);
        l.Add(0);
        l.Add(0);
        l.Add(0);
        l.Add(0);
        responses.Add(response1);
        responses.Add(response2);
        if (response3 != "optional") { responses.Add(response3); }
        if (response4 != "optional") { responses.Add(response4); }
        if(karma == null) {
            karma = new List<List<int>>();
            for (int i = 0; i< 5; i++)
            {               
                karma.Add(l);
            }
        }
        cResponseBasic basic = new cResponseBasic(responses, karma);
        this.cResponse.Add(basic);
    }

    public List<int> addKarma(string type, int emotion1, string type2 = "optional", int emotion2 = 0, string type3 = "optional", int emotion3 = 0)
    {
        List<int> karma = new List<int>();
        karma.Add(0);
        karma.Add(0);
        karma.Add(0);
        karma.Add(0);
        karma.Add(0);
        if (type == "love")
        {
            karma[0] = emotion1;
        }
        else if (type == "sadness")
        {
            karma[1] = emotion1;
        }
        else if (type == "hatred")
        {
            karma[2] = emotion1;
        }
        else if (type == "stability")
        {
            karma[3] = emotion1;
        }else if(type == "neutral")
        {
            karma[4] = emotion1;
        }

        if (type2 == "love")
        {
            karma[0] = emotion2;
        }
        else if (type2 == "sadness")
        {
            karma[1] = emotion2;
        }
        else if (type2 == "hatred")
        {
            karma[2] = emotion2;
        }
        else if (type2 == "stability")
        {
            karma[3] = emotion2;
        }
        else if (type2 == "neutral")
        {
            karma[4] = emotion2;
        }

        if (type3 == "love")
        {
            karma[0] = emotion3;
        }
        else if (type3 == "sadness")
        {
            karma[1] = emotion3;
        }
        else if (type3 == "hatred")
        {
            karma[2] = emotion3;
        }
        else if (type3 == "stability")
        {
            karma[3] = emotion3;
        }
        else if (type3 == "neutral")
        {
            karma[4] = emotion3;
        }

        return karma;
    }

    public List<List<int>> karmaResponses(List<int> k1, List<int> k2, List<int> k3 = null, List<int>k4 = null)
    {
        List<List<int>> karma = new List<List<int>>();
        karma.Add(k1);
        karma.Add(k2);
        if (k3 != null) { karma.Add(k3); };
        if (k4 != null) { karma.Add(k4); };

        return karma;
    }
}