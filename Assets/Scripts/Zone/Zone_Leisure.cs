using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Leisure : Zone
{
    public override Dictionary<string, (int, int, List<Building>)> getBuildingDictionary()
    {
        Dictionary<string, (int, int, List<Building>)> buildings = new Dictionary<string, (int, int, List<Building>)>
        {
            { "Theater", (0, 5, new List<Building>()) },
            { "Zoo", (0, 3, new List<Building>()) },
            { "Stadium", (0, 2, new List<Building>()) },
            { "Museum", (0, 1, new List<Building>()) },
            { "AmusementPark", (0, 1, new List<Building>()) },
            { "NaturalPark", (0, 1, new List<Building>()) },
        };

        return buildings;
    }
}