using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 命令：植树
public class Command_Afforest : Command
{
    Cell cell;
    
    public Command_Afforest(Cell cell)
    {
        this.cell = cell;
    }

    public override bool CheckCellState()
    {
        if(cell.state is not State_Undeveloped && cell.state is not State_Feature)
        {
            Debug.Log("无法造林：该单元格不是Undeveopled状态或Feature状态");
            return false;
        }
        return true;
    }
    public override void ChangeCellState()
    {
        cell.Afforest();
    }
}
