using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Commercial : Zone
{
    public override Dictionary<string, (int, int, List<Building>)> getBuildingDictionary()
    {
        Dictionary<string, (int, int, List<Building>)> buildings = new Dictionary<string, (int, int, List<Building>)>
        {
            { "Market", (0, new Market().init_limit, new List<Building>()) },
            { "Bank", (0, new Bank().init_limit, new List<Building>()) },
            { "Company", (0, new Company().init_limit, new List<Building>()) },
            { "StockExchange", (0, new StockExchange().init_limit, new List<Building>()) },
            { "FinancialCenter", (0, new FinancialCenter().init_limit, new List<Building>()) },
        };

        return buildings;
    }
}