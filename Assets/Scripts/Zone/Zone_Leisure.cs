using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Leisure : Zone
{
    public override Dictionary<string, (int, int, List<Building>)> getBuildingDictionary()
    {
        Dictionary<string, (int, int, List<Building>)> buildings = new Dictionary<string, (int, int, List<Building>)>
        {
            { "Theater", (0, new Theater().init_limit, new List<Building>()) },
            { "Zoo", (0, new Zoo().init_limit, new List<Building>()) },
            { "Stadium", (0, new Stadium().init_limit, new List<Building>()) },
            { "Museum", (0, new Museum().init_limit, new List<Building>()) },
            { "AmusementPark", (0, new AmusementPark().init_limit, new List<Building>()) },
            { "NaturalPark", (0, new NaturalPark().init_limit, new List<Building>()) },
        };

        return buildings;
    }
}