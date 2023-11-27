using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filter_Copper : IResourceFilter
{
    public bool isEnough(Zone zone)
    {
        return AssetManager.getInstance().Copper_Stock >= zone.cost_copper;
    }
}
