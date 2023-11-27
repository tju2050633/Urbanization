using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler_Stone : ConsumeHandler
{
    public Handler_Stone(ConsumeHandler handler) : base(handler) { }
    public override void consume(Zone zone)
    {
        AssetManager.getInstance().Stone_Stock -= zone.cost_stone;
        if (nextHandler != null)
            nextHandler.consume(zone);
    }
}
