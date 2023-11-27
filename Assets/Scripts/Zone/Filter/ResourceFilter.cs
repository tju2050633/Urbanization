using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 过滤器模式：建造区域前需要检查资源是否足够，涉及对金钱、木材、石材、铜、铁等资源的过滤
//（建筑的条件检查等一系列的逻辑都能用过滤器，但增加了复杂度，只在这里用以满足要求）
public interface IResourceFilter
{
    public bool isEnough(Zone zone);
}
