using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 状态：有地貌有资源
public class State_Feature_Resource : State
{
    public State_Feature_Resource(Cell cell) : base(cell)
    {
    }

    public override void RemoveFeature()
    {
        cell.state = new State_Resource(cell);
    }
    public override void HarvestResource()
    {
        cell.state = new State_Feature(cell);
    }
    public override void BuildZone()
    {
        Debug.LogError("无法建造区域：该单元格存在地貌和资源");
    }
    public override void Demolish()
    {
        Debug.LogError("无法拆除：该单元格没有区域");
    }
    public override void Afforest()
    {
        Debug.LogError("无法造林：该单元格存在地貌");
    }
}
