using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorator_Happiness : BuildingDecorator
{
    public Decorator_Happiness(Building building) : base(building) { }

    public override void yield(bool recaculate = true)
    {
        float lambda = 1;
        if (cell.happiness >= 200)
        {
            lambda = 1.5f;
        }
        else if (cell.happiness >= 100)
        {
            lambda = 1.2f;
        }
        else if (cell.happiness <= -100)
        {
            lambda = 0.5f;
        }
        else if (cell.happiness < 0)
        {
            lambda = 0.8f;
        }
        building.updateScale(lambda);
        
        building.yield();
    }
}
