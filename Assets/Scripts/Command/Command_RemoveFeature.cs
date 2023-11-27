using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 命令：移除地貌
public class Command_RemoveFeature : Command
{
    Cell cell;
    public Command_RemoveFeature(Cell cell)
    {
        this.cell = cell;
    }
    public override bool CheckCellState()
    {
        if(cell.state is not State_Feature && cell.state is not State_Feature_Resource)
        {
            Debug.Log("无法移除地貌：该单元格没有地貌");
            return false;
        }
        return true;
    }
    public override void Yield()
    {
        Dictionary<string, float> yield = cell.feature.GetYield();
        AssetManager.getInstance().Add_Stock(0, 0, yield["food"], 0, yield["wood"], yield["stone"], 0, 0);
    }
    public override void ChangeCellState()
    {
        cell.RemoveFeature();
    }
}
