using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 抽象工厂模式：建筑工厂的工厂，通过区域类型字符串获取对应类型的建筑工厂
public class BuildingFactoryProducer
{
    public BuildingFactory getFactory(string zoneType)
    {
        if (string.Equals(zoneType, "Residential", System.StringComparison.OrdinalIgnoreCase))
        {
            return new BuildingFactory_Residential();
        }
        else if (string.Equals(zoneType, "Agricultural", System.StringComparison.OrdinalIgnoreCase))
        {
            return new BuildingFactory_Agricultural();
        }
        else if (string.Equals(zoneType, "Academic", System.StringComparison.OrdinalIgnoreCase))
        {
            return new BuildingFactory_Academic();
        }
        else if (string.Equals(zoneType, "Commercial", System.StringComparison.OrdinalIgnoreCase))
        {
            return new BuildingFactory_Commercial();
        }
        else if (string.Equals(zoneType, "Industrial", System.StringComparison.OrdinalIgnoreCase))
        {
            return new BuildingFactory_Industrial();
        }
        else if (string.Equals(zoneType, "Leisure", System.StringComparison.OrdinalIgnoreCase))
        {
            return new BuildingFactory_Leisure();
        }
        else if (string.Equals(zoneType, "Military", System.StringComparison.OrdinalIgnoreCase))
        {
            return new BuildingFactory_Military();
        }
        else
        {
            Debug.LogError("区域类型字符串错误：" + zoneType);
            return null;
        }
    }
}
