using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 原型模式：资源是一个原型，可以被克隆
public  class Resource : ICloneable
{
    public object Clone()
    {
        return MemberwiseClone();
    }
    public float food = 0;
    public float gold = 0;
    public float copper = 0;
    public float iron = 0;
    public Dictionary<string, float> GetYield()
    {
        Dictionary<string, float> yield = new Dictionary<string, float>
        {
            { "food", food },
            { "gold", gold },
            { "copper", copper },
            { "iron", iron },
        };
        return yield;
    }
}
