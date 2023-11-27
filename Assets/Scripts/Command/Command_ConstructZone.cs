using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 命令：建造区域
public class Command_ConstructZone : Command
{
    Cell cell;
    Zone zone;
    Strategy strategy;
    public Command_ConstructZone(Cell cell, Zone zone, Strategy strategy)
    {
        this.cell = cell;
        this.zone = zone;
        this.strategy = strategy;
    }
    public override void execute()
    {
        strategy.constructZone(); // 策略：单元格可能自动执行移除地貌、收获资源等操作
        base.execute();
    }
    public override bool CheckCellState()
    {
        if(cell.state is not State_Undeveloped)
        {
            Debug.Log("无法建造区域：该单元格不是Undeveloped状态");
            return false;
        }
        return true;
    }
    public override bool CheckResource()
    {
        if(!zone.isResourceEnough())
        {
            Debug.Log("资源不足");
            return false;
        }
        return true;
    }
    public override void ConsumeResource()
    {
        zone.consumeResource();
    }
    public override void ChangeCellState()
    {
        cell.BuildZone(zone);
    }
}
