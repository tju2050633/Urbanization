using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 命令模式：命令实现execute()
// 模板模式：对单元格的命令都使用类似的步骤模板
public class Command
{
    public virtual void execute()
    {
        if(!CheckCellState())
        {
            return;
        }
        if(!CheckBuildingType())
        {
            return;
        }
        if(!CheckBuildingLimit())
        {
            return;
        }
        if(!CheckCondition())
        {
            return;
        }
        if(!CheckResource())
        {
            return;
        }
        ConsumeResource();
        Yield();
        ChangeCellState();
    }

    public virtual bool CheckCellState()
    {
        return true;
    }

    public virtual bool CheckBuildingType()
    {
        return true;
    }

    public virtual bool CheckBuildingLimit()
    {
        return true;
    }

    public virtual bool CheckCondition()
    {
        return true;
    }

    public virtual bool CheckResource()
    {
        return true;
    }

    public virtual void ConsumeResource()
    {

    }

    public virtual void Yield()
    {

    }

    public virtual void ChangeCellState()
    {

    }
}
