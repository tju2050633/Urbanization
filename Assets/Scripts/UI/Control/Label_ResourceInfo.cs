using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 控制面板-资源信息标签
public class Label_ResourceInfo : UI_Component
{
    public override void update_info(UI_Updater updater)
    {
        updater.update(this, "resource_info");
    }
}
