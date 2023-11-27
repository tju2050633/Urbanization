using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filter_Iron : IResourceFilter
{
    public bool isEnough(Zone zone)
    {
        return AssetManager.getInstance().Iron_Stock >= zone.cost_iron;
    }
}
