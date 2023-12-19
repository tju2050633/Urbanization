using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Academic : Zone
{
    public override Dictionary<string, (int, int, List<Building>)> getBuildingDictionary()
    {
        Dictionary<string, (int, int, List<Building>)> buildings = new Dictionary<string, (int, int, List<Building>)>
        {
            { "PrimarySchool", (0, new PrimarySchool().init_limit, new List<Building>()) },
            { "MiddleSchool", (0, new MiddleSchool().init_limit, new List<Building>()) },
            { "University", (0, new University().init_limit, new List<Building>()) },
            { "MilitaryCollege", (0, new MilitaryCollege().init_limit, new List<Building>()) },
            { "Library", (0, new Library().init_limit, new List<Building>()) },
            { "ResearchInstitute", (0, new ResearchInstitute().init_limit, new List<Building>()) }
        };

        return buildings;
    }
}