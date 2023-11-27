using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Agricultural : Zone
{
    public override Dictionary<string, (int, int, List<Building>)> getBuildingDictionary()
    {
        Dictionary<string, (int, int, List<Building>)> buildings = new Dictionary<string, (int, int, List<Building>)>
        {
            { "Granary", (0, 3, new List<Building>()) },
            { "Farm", (0, 5, new List<Building>()) },
            { "Orchard", (0, 5, new List<Building>()) },
            { "Ranche", (0, 5, new List<Building>()) },
            { "MechanizedFarm", (0, 1, new List<Building>()) },
            { "MechanizedOrchard", (0, 1, new List<Building>()) },
            { "MechanizedRanche", (0, 1, new List<Building>()) },
        };

        return buildings;
    }


}
