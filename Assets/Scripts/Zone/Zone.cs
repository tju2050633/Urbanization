using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 区域基类
// 原型模式：区域是一个原型，可以被克隆
public abstract class Zone : ICloneable
{
    public float cost_gold = 500;
    public float cost_wood = 200;
    public float cost_stone = 100;
    public float cost_copper = 100;
    public float cost_iron = 100;
    public object Clone()
    {
        return MemberwiseClone();
    }

    // 获取特定区域下建筑的字典，key为建筑的名称，value为建筑的当前数量、上限和建筑对象列表
    public abstract Dictionary<string, (int, int, List<Building>)> getBuildingDictionary();
    
    // 检查建造区域的资源是否足够
    public bool isResourceEnough()
    {
        return getFilterChain().isEnough(this);
    }

    public FilterChain getFilterChain()
    {
        FilterChain chain = new FilterChain();
        chain.addFilter(new Filter_Gold());
        chain.addFilter(new Filter_Wood());
        chain.addFilter(new Filter_Stone());
        chain.addFilter(new Filter_Copper());
        chain.addFilter(new Filter_Iron());

        return chain;
    }

    // 消耗资源
    public void consumeResource()
    {
        getHandlerChain().consume(this);
    }

    public ConsumeHandler getHandlerChain()
    {
        ConsumeHandler handler_iron = new Handler_Iron(null);
        ConsumeHandler handler_copper = new Handler_Copper(handler_iron);
        ConsumeHandler handler_stone = new Handler_Stone(handler_copper);
        ConsumeHandler handler_wood = new Handler_Wood(handler_stone);
        ConsumeHandler handler_gold = new Handler_Gold(handler_wood);
        return handler_gold;
    }
}
