using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cResponseBasic
{
    public List<string> cResponse = new List<string>();
    public List<List<int>> karma = new List<List<int>>();

    public cResponseBasic(List<string> cResponse, List<List<int>> karma)
    {
        this.cResponse = cResponse;
        this.karma = karma;
    }

}
