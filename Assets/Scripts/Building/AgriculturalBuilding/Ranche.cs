using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranche : Building
{
    public Ranche()
    {
        init_limit = 5;
        cost_gold = 100;
        cost_wood = 100;
        cost_stone = 100;
        yield_food = 40;
        yield_gold_incre = 2;
        lower_building_limit_incre.Add("Granary", 1);
    }

    public override void updateBonus()
    {
        if (cell.pollution >= 50)
        {
            yield_food = 0;
            yield_gold_incre = 0;
        }
        else if (cell.commercialization >= 500)
        {
            yield_gold_incre += 1;
        }
    }
}