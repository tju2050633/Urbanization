using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 策略基类
// 策略模式：根据控制面板勾选情况，决定建造区域的操作策略
public abstract class Strategy
{
    protected Cell cell;
    public void setCell(Cell cell)
    {
        this.cell = cell;
    }
    public abstract void constructZone();
}
