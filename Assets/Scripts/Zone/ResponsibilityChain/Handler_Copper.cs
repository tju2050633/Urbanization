using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler_Copper : ConsumeHandler
{
    public Handler_Copper(ConsumeHandler handler) : base(handler) { }
    public override void consume(Zone zone)
    {
        AssetManager.getInstance().Copper_Stock -= zone.cost_copper;
        if (nextHandler != null)
            nextHandler.consume(zone);
    }
}
