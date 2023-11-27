using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 状态：无地貌、无资源，但尚未开发或被废弃
public class State_Undeveloped : State
{
    public State_Undeveloped(Cell cell) : base(cell)
    {
    }

    public override void RemoveFeature()
    {
        Debug.LogError("无法移除地貌：该单元格没有地貌");
    }
    public override void HarvestResource()
    {
        Debug.LogError("无法收获资源：该单元格没有资源");
    }
    public override void BuildZone()
    {
        cell.state = new State_Developed(cell);
    }
    public override void Demolish()
    {
        Debug.LogError("无法拆除区域：该单元格没有区域");
    }
    public override void Afforest()
    {
        cell.state = new State_Feature(cell);
    }
}
