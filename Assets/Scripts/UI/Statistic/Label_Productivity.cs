using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Label_Productivity : UI_Component
{
    public override void update_info(UI_Updater updater)
    {
        updater.update(this, "productivity");
    }
}
