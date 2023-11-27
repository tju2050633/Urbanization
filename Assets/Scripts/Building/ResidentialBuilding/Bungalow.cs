using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bungalow : Building
{
    public Bungalow()
    {
        init_limit = 3;
        cost_gold = 100;
        cost_wood = 100;
        cost_stone = 100;
        yield_accommodation = 10;
        lower_building_limit_incre.Add("Slum", 2);
    }
}
