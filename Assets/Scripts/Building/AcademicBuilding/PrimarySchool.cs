using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimarySchool : Building
{
    public PrimarySchool()
    {
        init_limit = 5;
        cost_gold = 200;
        cost_wood = 100;
        cost_stone = 100;
        yield_science = 10;
    }

    public override void updateBonus()
    {
        if (AssetManager.getInstance().Population_Stock >= 100)
        {
            yield_science += 5;
        }
    }
}