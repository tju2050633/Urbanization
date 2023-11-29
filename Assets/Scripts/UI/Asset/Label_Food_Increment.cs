using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Label_Food_Increment : UI_Component
{
    public override void update_info(UI_Updater updater)
    {
        updater.update(this, "population_increment");
    }
}
