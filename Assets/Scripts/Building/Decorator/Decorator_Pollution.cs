using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorator_Pollution : BuildingDecorator
{
    public Decorator_Pollution(Building building) : base(building) { }

    public override void yield(bool recaculate = true)
    {
        float lambda = 1;
        if (cell.pollution >= 300)
        {
            lambda = 0.2f;
        }
        else if (cell.pollution >= 200)
        {
            lambda = 0.5f;
        }
        else if (cell.pollution >= 100)
        {
            lambda = 0.8f;
        }
        building.updateScale(lambda);

        building.yield();
    }
}
