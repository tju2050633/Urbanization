using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechanizedRanche : Building
{
    public MechanizedRanche()
    {
        init_limit = 1;
        unlock_science = 500;
        unlock_productivity = 500;
        cost_gold = 1000;
        cost_wood = 300;
        cost_stone = 500;
        cost_copper = 1000;
        cost_iron = 1000;
        yield_food = 200;
        yield_gold_incre = 10;
        lower_building_limit_incre.Add("Ranche", 5);
    }

    public override void updateBonus()
    {
        if (cell.electricity >= 200)
        {
            yield_food += 200;
            yield_gold_incre += 10;
        }
        if (cell.commercialization >= 500)
        {
            yield_gold_incre += 5;
        }
    }
}