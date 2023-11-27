using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain : ICloneable
{
    public List<string> featureList = new List<string>();
    public List<string> resourceList = new List<string>();
    public object Clone()
    {
        return MemberwiseClone();
    }
}
