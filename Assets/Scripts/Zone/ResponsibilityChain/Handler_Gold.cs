using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler_Gold : ConsumeHandler
{
    public Handler_Gold(ConsumeHandler handler) : base(handler) { }
    public override void consume(Zone zone)
    {
        AssetManager.getInstance().Gold_Stock -= zone.cost_gold;
        if (nextHandler != null)
            nextHandler.consume(zone);
    }
}
