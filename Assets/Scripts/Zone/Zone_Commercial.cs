using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Commercial : Zone
{
    public override Dictionary<string, (int, int, List<Building>)> getBuildingDictionary()
    {
        Dictionary<string, (int, int, List<Building>)> buildings = new Dictionary<string, (int, int, List<Building>)>
        {
            { "Market", (0, 5, new List<Building>()) },
            { "Bank", (0, 3, new List<Building>()) },
            { "Company", (0, 2, new List<Building>()) },
            { "StockExchange", (0, 1, new List<Building>()) },
            { "FinancialCenter", (0, 1, new List<Building>()) },
        };

        return buildings;
    }
}