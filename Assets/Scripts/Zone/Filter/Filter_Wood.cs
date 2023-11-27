using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filter_Wood : IResourceFilter
{
    public bool isEnough(Zone zone)
    {
        return AssetManager.getInstance().Wood_Stock >= zone.cost_wood;
    }
}
