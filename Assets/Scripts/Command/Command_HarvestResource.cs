using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 命令：收获资源
public class Command_HarvestResource : Command
{
    Cell cell;
    public Command_HarvestResource(Cell cell)
    {
        this.cell = cell;
    }
    public override bool CheckCellState()
    {
        if (cell.state is not State_Resource && cell.state is not State_Feature_Resource)
        {
            Debug.Log("无法收获资源：该单元格没有资源");
            return false;
        }
        return true;
    }
    public override bool CheckResource()
    {
        if (AssetManager.getInstance().Gold_Stock + cell.resource.GetYield()["gold"] < 0)
        {
            Debug.Log("金钱不足");
            return false;
        }
        return true;
    }
    public override void Yield()
    {
        Dictionary<string, float> yield = cell.resource.GetYield();
        // 这里yield["gold"]为负数，在yield里消耗了资源
        AssetManager.getInstance().Add_Stock(0, 0, yield["food"], yield["gold"], 0, 0, yield["copper"], yield["iron"]);
    }
    public override void ChangeCellState()
    {
        cell.HarvestResource();
    }
}
