using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Residential : Zone
{
    public override Dictionary<string, (int, int, List<Building>)> getBuildingDictionary()
    {
        Dictionary<string, (int, int, List<Building>)> buildings = new Dictionary<string, (int, int, List<Building>)>
        {
            { "Slum", (0, new Slum().init_limit, new List<Building>()) },
            { "Bungalow", (0, new Bungalow().init_limit, new List<Building>()) },
            { "Apartment", (0, new Apartment().init_limit, new List<Building>()) },
            { "Skyscraper", (0, new Skyscraper().init_limit, new List<Building>()) },
            { "Villa", (0, new Villa().init_limit, new List<Building>()) },
        };

        return buildings;
    }
}