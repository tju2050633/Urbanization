using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Label_Food_Stock : UI_Component
{
    public override void update_info(UI_Updater updater)
    {
        updater.update(this, "food_stock");
    }
}
