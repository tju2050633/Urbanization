using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 状态：有区域
public class State_Developed : State
{
    public State_Developed(Cell cell) : base(cell)
    {
    }

    public override void RemoveFeature()
    {
        Debug.LogError("无法移除地貌：该单元格已经被开发");
    }
    public override void HarvestResource()
    {
        Debug.LogError("无法收获资源：该单元格已经被开发");
    }
    public override void BuildZone()
    {
        Debug.LogError("无法建造区域：该单元格已经被开发");
    }
    public override void Demolish()
    {
        cell.state = new State_Undeveloped(cell);
    }
    public override void Afforest()
    {
        Debug.LogError("无法造林：该单元格已经被开发");
    }
}
