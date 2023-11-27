using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 策略：自动移除地貌、收获资源
public class Strategy_RemoveFeature_HarvestResource : Strategy
{
    public override void constructZone()
    {
        cell.RemoveFeature();
        cell.HarvestResource();
    }
}
