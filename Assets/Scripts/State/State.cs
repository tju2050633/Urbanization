using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 状态基类
// 状态模式：单元格根据经过的操作有几种状态，不同状态可以进行不同的操作
public abstract class State
{
    public Cell cell;
    public State(Cell cell)
    {
        this.cell = cell;
    }

    public abstract void RemoveFeature();
    public abstract void HarvestResource();
    public abstract void BuildZone();
    public abstract void Demolish();
    public abstract void Afforest();
}
