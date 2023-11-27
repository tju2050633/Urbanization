using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granary : Building
{
    public Granary()
    {
        init_limit = 3;
        yield_food = 30;
    }
}
