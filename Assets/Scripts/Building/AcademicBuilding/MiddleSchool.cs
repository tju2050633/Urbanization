using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleSchool : Building
{
    public MiddleSchool()
    {
        init_limit = 3;
        unlock_science = 50;
        cost_gold = 500;
        cost_wood = 200;
        cost_stone = 200;
        yield_science = 20;
        lower_building_limit_incre.Add("PrimarySchool", 1);
    }

    public override void updateBonus()
    {
        if (cell.electricity >= 200)
        {
            yield_science += 10;
        }
    }
}