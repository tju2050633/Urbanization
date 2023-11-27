using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 策略：自动移除地貌
public class Strategy_RemoveFeature : Strategy
{
    public override void constructZone()
    {
        cell.RemoveFeature();
    }
}
