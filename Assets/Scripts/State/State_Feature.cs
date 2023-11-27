using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 状态：有地貌
public class State_Feature : State
{
    public State_Feature(Cell cell) : base(cell)
    {
    }

    public override void RemoveFeature()
    {
        cell.state = new State_Undeveloped(cell);
    }
    public override void HarvestResource()
    {
        Debug.LogError("无法收获资源：该单元格没有资源");
    }
    public override void BuildZone()
    {
        Debug.LogError("无法建造区域：该单元格存在地貌");
    }
    public override void Demolish()
    {
        Debug.LogError("无法拆除区域：该单元格没有区域");
    }
    public override void Afforest()
    {
        Debug.LogError("无法造林：该单元格存在地貌");
    }
}
