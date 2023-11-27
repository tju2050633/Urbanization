using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 命令：废弃地块
public class Command_Demolish : Command
{
    Cell cell;
    public Command_Demolish(Cell cell)
    {
        this.cell = cell;
    }
    public override bool CheckCellState()
    {
        if(cell.state is not State_Developed)
        {
            Debug.Log("无法拆除区域：该单元格没有区域");
            return false;
        }
        return true;
    }
    public override void ChangeCellState()
    {
        cell.Demolish();
    }
}
