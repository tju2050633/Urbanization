using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slum : Building
{
    public Slum()
    {
        init_limit = 1;
        yield_accommodation = 50;
        yield_happiness = (1, -30);
        yield_pollutation = (2, 10);
    }
}
