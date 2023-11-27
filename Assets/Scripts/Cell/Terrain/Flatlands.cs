using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flatlands : Terrain
{
    public Flatlands()
    {
        featureList.Add("Woods");
        featureList.Add("Rainforest");
        featureList.Add("Stone");

        resourceList.Add("Pig");
        resourceList.Add("Sheep");
        resourceList.Add("Horse");
    }
}
