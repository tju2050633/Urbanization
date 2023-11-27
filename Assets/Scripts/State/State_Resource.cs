using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 状态：有资源
public class State_Resource : State
{
    public State_Resource(Cell cell) : base(cell)
    {
    }

    public override void RemoveFeature()
    {
        Debug.LogError("无法移除地貌：该单元格没有地貌");
    }
    public override void HarvestResource()
    {
        cell.state = new State_Undeveloped(cell);
    }
    public override void BuildZone()
    {
        Debug.LogError("无法建造区域：该单元格存在资源");
    }
    public override void Demolish()
    {
        Debug.LogError("无法拆除：该单元格没有区域");
    }
    public override void Afforest()
    {
        cell.state = new State_Feature_Resource(cell);
    }
}   
