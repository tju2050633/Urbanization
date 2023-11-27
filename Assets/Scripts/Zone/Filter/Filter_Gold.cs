using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filter_Gold : IResourceFilter
{
    public bool isEnough(Zone zone)
    {
        return AssetManager.getInstance().Gold_Stock >= zone.cost_gold;
    }
}
