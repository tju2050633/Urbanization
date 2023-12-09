using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Academic : Zone
{
    public override Dictionary<string, (int, int, List<Building>)> getBuildingDictionary()
    {
        Dictionary<string, (int, int, List<Building>)> buildings = new Dictionary<string, (int, int, List<Building>)>
        {
            { "PrimartSchool", (0, 5, new List<Building>()) },
            { "MiddleSchool", (0, 3, new List<Building>()) },
            { "University", (0, 2, new List<Building>()) },
            { "MilitaryCollege", (0, 1, new List<Building>()) },
            { "Library", (0, 3, new List<Building>()) },
            { "ResearchInstitute", (0, 1, new List<Building>()) },
        };

        return buildings;
    }
}