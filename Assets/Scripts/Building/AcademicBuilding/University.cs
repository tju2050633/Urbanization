using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class University : Building
{
    public University()
    {
        init_limit = 2;
        unlock_science = 100;
        unlock_productivity = 100;
        unlock_electricity = 100;
        cost_gold = 1000;
        cost_wood = 500;
        cost_stone = 500;
        cost_copper = 200;
        cost_iron = 200;
        yield_science = 50;
        lower_building_limit_incre.Add("MiddleSchool", 2);
    }

    public override void updateBonus()
    {
        if (cell.electricity >= 500)
        {
            yield_science += 20;
        }
    }
}