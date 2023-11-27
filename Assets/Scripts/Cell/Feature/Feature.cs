using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 原型模式：地貌是一个原型，可以被克隆
public  class Feature : ICloneable
{
    public object Clone()
    {
        return MemberwiseClone();
    }

    public float wood = 0;
    public float food = 0;
    public float stone = 0;

    public Dictionary<string, float> GetYield()
    {
        Dictionary<string, float> yield = new Dictionary<string, float>
        {
            { "wood", wood },
            { "food", food },
            { "stone", stone}
        };
        return yield;
    }
}
