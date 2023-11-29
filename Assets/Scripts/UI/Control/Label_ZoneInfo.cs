using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 控制面板-区域信息标签
public class Label_ZoneInfo : UI_Component
{
    public override void update_info(UI_Updater updater)
    {
        updater.update(this, "zone_info");
    }
}
