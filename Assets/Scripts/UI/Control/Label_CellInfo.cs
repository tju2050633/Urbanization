using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 控制面板-单元格信息标签
public class Label_CellInfo : UI_Component
{
    public override void update_info(UI_Updater updater)
    {
        updater.update(this, "cell_info");
    }
}
