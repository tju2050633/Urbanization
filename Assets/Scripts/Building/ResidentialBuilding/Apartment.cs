using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apartment : Building
{
    public Apartment()
    {
        init_limit = 2;
        unlock_productivity = 100;
        unlock_science = 50;
        cost_gold = 200;
        cost_wood = 200;
        cost_stone = 200;
        cost_iron = 100;
        yield_accommodation = 30;
        lower_building_limit_incre.Add("Bungalow", 1);
    }

    public override void updateBonus()
    {
        if (cell.electricity >= 10)
        {
            yield_accommodation += 10;
        }
    }
}
