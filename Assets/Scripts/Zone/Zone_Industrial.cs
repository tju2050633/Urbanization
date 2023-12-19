using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Industrial : Zone
{
    public override Dictionary<string, (int, int, List<Building>)> getBuildingDictionary()
    {
        Dictionary<string, (int, int, List<Building>)> buildings = new Dictionary<string, (int, int, List<Building>)>
        {
            { "Workshop", (0, new Workshop().init_limit, new List<Building>()) },
            { "Factory", (0, new Factory().init_limit, new List<Building>()) },
            { "ElectronicsFactory", (0, new ElectronicsFactory().init_limit, new List<Building>()) },
            { "MilitaryFactory", (0, new MilitaryFactory().init_limit, new List<Building>()) },
            { "ThermalPowerPlant", (0, new ThermalPowerPlant().init_limit, new List<Building>()) },
            { "NuclearPowerPlant", (0, new NuclearPowerPlant().init_limit, new List<Building>()) },
        };

        return buildings;
    }
}