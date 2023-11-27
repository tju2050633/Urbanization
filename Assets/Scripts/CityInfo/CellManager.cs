using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 单例模式：管理所有单元格
public class CellManager
{
    private static CellManager _instance = new CellManager();
    private CellManager() { }
    public static CellManager getInstance()
    {
        return _instance;
    }
}
