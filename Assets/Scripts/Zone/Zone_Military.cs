using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Military : Zone
{
    public override Dictionary<string, (int, int, List<Building>)> getBuildingDictionary()
    {
        Dictionary<string, (int, int, List<Building>)> buildings = new Dictionary<string, (int, int, List<Building>)>
        {
            { "Stable", (0, new Stable().init_limit, new List<Building>()) },
            { "Barrack", (0, new Barrack().init_limit, new List<Building>()) },
            { "Hangar", (0, new Hangar().init_limit, new List<Building>()) },
            { "MilitaryBase", (0, new MilitaryBase().init_limit, new List<Building>()) },
        };

        return buildings;
    }
}