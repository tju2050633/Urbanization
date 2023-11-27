using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hill : Terrain
{
    public Hill()
    {
        featureList.Add("Woods");
        featureList.Add("Rainforest");
        featureList.Add("Stone");

        resourceList.Add("Iron");
        resourceList.Add("Copper");
        resourceList.Add("Gold");
    }
}
