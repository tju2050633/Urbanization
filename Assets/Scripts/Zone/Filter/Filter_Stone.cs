using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filter_Stone : IResourceFilter
{
    public bool isEnough(Zone zone)
    {
        return AssetManager.getInstance().Stone_Stock >= zone.cost_stone;
    }
}
