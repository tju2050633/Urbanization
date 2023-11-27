using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler_Iron : ConsumeHandler
{
    public Handler_Iron(ConsumeHandler handler) : base(handler) { }
    public override void consume(Zone zone)
    {
        AssetManager.getInstance().Iron_Stock -= zone.cost_iron;
        if (nextHandler != null)
            nextHandler.consume(zone);
    }
}
