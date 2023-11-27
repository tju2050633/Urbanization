using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : Building
{
    public Farm()
    {
        init_limit = 5;
        cost_gold = 100;
        cost_wood = 100;
        cost_stone = 100;
        yield_food = 100;
        lower_building_limit_incre.Add("Granary", 1);
    }

    public override void updateBonus()
    {
        if (cell.pollution >= 50)
        {
            yield_food = 0;
        }
    }
}