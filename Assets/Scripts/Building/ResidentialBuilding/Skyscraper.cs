using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyscraper : Building
{
    public Skyscraper()
    {
        init_limit = 1;
        unlock_productivity = 1000;
        unlock_science = 500;
        unlock_electricity = 100;
        cost_gold = 3000;
        cost_wood = 1000;
        cost_stone = 2000;
        cost_copper = 1000;
        cost_iron = 3000;
        yield_accommodation = 200;
        lower_building_limit_incre.Add("Apartment", 5);
        yield_happiness = (1, 30);
    }

    public override void updateBonus()
    {
        if (cell.electricity >= 300)
        {
            yield_accommodation += 300;
        }
    }
}