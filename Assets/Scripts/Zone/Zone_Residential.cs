using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Residential : Zone
{
    public override Dictionary<string, (int, int, List<Building>)> getBuildingDictionary()
    {
        Dictionary<string, (int, int, List<Building>)> buildings = new Dictionary<string, (int, int, List<Building>)>
        {
            { "Slum", (0, 1, new List<Building>()) },
            { "Bungalow", (0, 3, new List<Building>()) },
            { "Apartment", (0, 2, new List<Building>()) },
            { "Skyscraper", (0, 1, new List<Building>()) },
            { "Villa", (0, 10, new List<Building>()) },
        };

        return buildings;
    }
}