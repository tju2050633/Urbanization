using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Label_Accommodation : UI_Component
{
    public override void update_info(UI_Updater updater)
    {
        updater.update(this, "accommodation");
    }
}
