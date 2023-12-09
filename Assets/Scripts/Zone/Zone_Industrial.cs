using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Industrial : Zone
{
    public override Dictionary<string, (int, int, List<Building>)> getBuildingDictionary()
    {
        Dictionary<string, (int, int, List<Building>)> buildings = new Dictionary<string, (int, int, List<Building>)>
        {
            { "Workshop", (0, 5, new List<Building>()) },
            { "Factory", (0, 3, new List<Building>()) },
            { "ElectronicsFactory", (0, 2, new List<Building>()) },
            { "MilitaryFactory", (0, 3, new List<Building>()) },
            { "ThermalPowerPlant", (0, 5, new List<Building>()) },
            { "NuclearPowerPlant", (0, 1, new List<Building>()) },
        };

        return buildings;
    }
}