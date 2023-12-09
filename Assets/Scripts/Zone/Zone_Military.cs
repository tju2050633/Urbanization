using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Military : Zone
{
    public override Dictionary<string, (int, int, List<Building>)> getBuildingDictionary()
    {
        Dictionary<string, (int, int, List<Building>)> buildings = new Dictionary<string, (int, int, List<Building>)>
        {
            { "Stable", (0, 5, new List<Building>()) },
            { "Barrack", (0, 3, new List<Building>()) },
            { "Hangar", (0, 2, new List<Building>()) },
            { "MilitaryBase", (0, 1, new List<Building>()) },
        };

        return buildings;
    }
}