using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler_Wood : ConsumeHandler
{
    public Handler_Wood(ConsumeHandler handler) : base(handler) { }
    public override void consume(Zone zone)
    {
        AssetManager.getInstance().Wood_Stock -= zone.cost_wood;
        if (nextHandler != null)
            nextHandler.consume(zone);
    }
}
