using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 命令：建造建筑
public class Command_ConstructBuilding : Command
{
    Cell cell;
    Building building;
    public Command_ConstructBuilding(Cell cell, Building building)
    {
        this.cell = cell;
        this.building = building;
        building.cell = cell;
    }

    public override bool CheckCellState()
    {
        if(cell.state is not State_Developed)
        {
            Debug.Log("无法建造建筑：该单元格不是Developed状态");
            return false;
        }
        return true;
    }
    public override bool CheckBuildingType()
    {
        string buildingType = building.GetType().ToString();

        if(!cell.buildings.ContainsKey(buildingType))
        {
            Debug.Log("建筑类型不符合区域");
            return false;
        }
        return true;
    }
    public override bool CheckBuildingLimit()
    {
        string buildingType = building.GetType().ToString();

        if(cell.buildings[buildingType].Item1 >= cell.buildings[buildingType].Item2)
        {
            Debug.Log("建筑数量达到上限");
            return false;
        }
        return true;
    }
    public override bool CheckCondition()
    {
        if(!building.isConditionMet())
        {
            Debug.Log("建筑条件不满足");
            return false;
        }
        return true;
    }
    public override bool CheckResource()
    {
        if(!building.isResourceEnough())
        {
            Debug.Log("建筑所需资源不足");
            return false;
        }
        return true;
    }
    public override void ConsumeResource()
    {
        building.consumeResource();
    }
    public override void Yield()
    {
        building.yield();
    }
    public override void ChangeCellState()
    {
        cell.BuildBuilding(building);
    }
}
