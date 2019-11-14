using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cResponseHappiness
{
    public List<cResponseBasic> cResponse = new List<cResponseBasic>();

    public cResponseHappiness(List<cResponseBasic> cResponse)
    {
        this.cResponse = cResponse;
    }

    public void addResponse(string response1, string response2, string response3 = "optional", string response4 = "optional")
    {
        List<string> responses = new List<string>();
        responses.Add(response1);
        responses.Add(response2);
        if (response3 != "optional") { responses.Add(response3); }
        if (response4 != "optional") { responses.Add(response4); }
        cResponseBasic basic = new cResponseBasic(responses);
        this.cResponse.Add(basic);
    }
}
