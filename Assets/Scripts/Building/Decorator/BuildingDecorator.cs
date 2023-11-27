using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 装饰器基类
// 装饰器模式：负责幸福程度、污染程度的产出比例增减益计算
public abstract class BuildingDecorator : Building
{
    protected Building building;
    public BuildingDecorator(Building building)
    {
        this.building = building;
    }

    public override void yield(bool recaculate = true)
    {
        building.yield();
    }
}
