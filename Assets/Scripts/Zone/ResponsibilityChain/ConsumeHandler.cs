using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 责任链模式：建造区域的开销有消耗金钱、木材、石材、铜、铁等步骤，建模成责任链
//（建筑的条件检查、开销、产出等一系列的逻辑都能用责任链，但增加了复杂度，只在这里用以满足要求）
public abstract class ConsumeHandler
{
    protected ConsumeHandler nextHandler = null;
    public ConsumeHandler(ConsumeHandler handler)
    {
        nextHandler = handler;
    }

    public abstract void consume(Zone zone);
}
