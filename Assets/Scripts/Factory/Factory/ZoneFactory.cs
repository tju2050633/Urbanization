using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 工厂模式：区域工厂，通过区域类型字符串获取区域
public class ZoneFactory
{
    public Zone getZone(string zoneType)
    {
        return CacheFacade.getInstance().cloneZone(zoneType);
    }
}