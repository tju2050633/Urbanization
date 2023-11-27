using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villa : Building
{
    public Villa()
    {
        init_limit = 10;
        unlock_productivity = 500;
        unlock_science = 100;
        cost_gold = 800;
        cost_wood = 300;
        cost_stone = 300;
        cost_copper = 100;
        cost_iron = 200;
        yield_accommodation = 15;
        yield_happiness = (1, 100);
    }
}