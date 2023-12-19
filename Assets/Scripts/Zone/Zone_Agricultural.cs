using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Agricultural : Zone
{
    public override Dictionary<string, (int, int, List<Building>)> getBuildingDictionary()
    {
        Dictionary<string, (int, int, List<Building>)> buildings = new Dictionary<string, (int, int, List<Building>)>
        {
            { "Granary", (0, new Granary().init_limit, new List<Building>()) },
            { "Farm", (0, new Farm().init_limit, new List<Building>()) },
            { "Orchard", (0, new Orchard().init_limit, new List<Building>()) },
            { "Ranche", (0, new Ranche().init_limit, new List<Building>()) },
            { "MechanizedFarm", (0, new MechanizedFarm().init_limit, new List<Building>()) },
            { "MechanizedOrchard", (0, new MechanizedOrchard().init_limit, new List<Building>()) },
            { "MechanizedRanche", (0, new MechanizedRanche().init_limit, new List<Building>()) },
        };

        return buildings;
    }


}
