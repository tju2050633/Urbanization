using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 策略：自动收获资源
public class Strategy_HarvestResource : Strategy
{
    public override void constructZone()
    {
        cell.HarvestResource();
    }
}
