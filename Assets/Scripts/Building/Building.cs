using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 所有类型建筑的基类
// 观察者模式：单元格是被观察者，建筑是观察者
public class Building
{
    public Cell cell;

    // 初始建造上限
    public int init_limit = 0;

    // 解锁条件
    public float unlock_science = 0;
    public float unlock_culture = 0;
    public float unlock_commercialization = 0;
    public float unlock_military = 0;
    public float unlock_productivity = 0;
    public float unlock_electricity = 0;

    // 资源消耗
    public float cost_gold = 0;
    public float cost_wood = 0;
    public float cost_stone = 0;
    public float cost_copper = 0;
    public float cost_iron = 0;

    // 产出
    public float yield_accommodation = 0;
    public float yield_food = 0;
    public float yield_gold_incre = 0;
    public float yield_science = 0;
    public float yield_culture = 0;
    public float yield_commercialization = 0;
    public float yield_military = 0;
    public float yield_productivity = 0;
    // 这几种产出对距离≤n的所有单元格生效
    public (int, float) yield_electricity = (0, 0);
    public (int, float) yield_happiness = (0, 0);
    public (int, float) yield_pollution = (0, 0);

    // 低级建筑上限增加
    public Dictionary<string, int> lower_building_limit_incre = new Dictionary<string, int>();

    // 额外产出条件和值
    public (float, float) bonus_electricity = (0, 0);
    public (float, float) bonus_commercialization = (0, 0);
    public (float, float) bonus_science = (0, 0);
    public (float, float) bonus_culture = (0, 0);
    public (float, float) bonus_happiness = (0, 0);
    public (float, float) bonus_pollution = (0, 0);

    public bool isResourceEnough() // 资源是否足够
    {
        if (AssetManager.getInstance().Gold_Stock < cost_gold)
            return false;
        if (AssetManager.getInstance().Wood_Stock < cost_wood)
            return false;
        if (AssetManager.getInstance().Stone_Stock < cost_stone)
            return false;
        if (AssetManager.getInstance().Copper_Stock < cost_copper)
            return false;
        if (AssetManager.getInstance().Iron_Stock < cost_iron)
            return false;
        return true;
    }
    public void consumeResource() // 消耗资源
    {
        AssetManager.getInstance().Gold_Stock -= cost_gold;
        AssetManager.getInstance().Wood_Stock -= cost_wood;
        AssetManager.getInstance().Stone_Stock -= cost_stone;
        AssetManager.getInstance().Copper_Stock -= cost_copper;
        AssetManager.getInstance().Iron_Stock -= cost_iron;
    }
    public bool isConditionMet() // 解锁条件是否满足
    {
        if (StatisticManager.getInstance().Science_Level < unlock_science)
            return false;
        if (StatisticManager.getInstance().Culture_Level < unlock_culture)
            return false;
        if (StatisticManager.getInstance().Commercialization < unlock_commercialization)
            return false;
        if (StatisticManager.getInstance().MilitaryPower < unlock_military)
            return false;
        if (StatisticManager.getInstance().Productivity < unlock_productivity)
            return false;
        if (cell.electricity < unlock_electricity)
            return false;
        return true;
    }

    public virtual void yield(bool recaculate = true) // 将产出计算到单元格和城市的Asset和Statistics里
    {
        cell.accommodation += yield_accommodation;
        cell.food += yield_food;
        cell.gold += yield_gold_incre;
        cell.science += yield_science;
        cell.culture += yield_culture;
        cell.commercialization += yield_commercialization;
        cell.productivity += yield_productivity;
        cell.military += yield_military;

        if (recaculate)
            cell.Recaculate();

        foreach (Cell c in cell.getNeighborCells(yield_electricity.Item1))
        {
            c.electricity += yield_electricity.Item2;
            if (recaculate)
                c.Recaculate();
        }
        foreach (Cell c in cell.getNeighborCells(yield_happiness.Item1))
        {
            c.happiness += yield_happiness.Item2;
            if (recaculate)
                c.Recaculate();
        }
        foreach (Cell c in cell.getNeighborCells(yield_pollution.Item1))
        {
            c.pollution += yield_pollution.Item2;
            if (recaculate)
                c.Recaculate();
        }
    }
    public virtual void updateBonus() // 某些条件下更新产出增益，让具体建筑类实现
    {

    }

    public void updateScale(float lambda)   // 幸福程度、污染程度造成的产出增减益百分比变化
    {
        yield_accommodation *= lambda;
        yield_food *= lambda;
        yield_gold_incre *= lambda;
        yield_science *= lambda;
        yield_culture *= lambda;
        yield_commercialization *= lambda;
        yield_military *= lambda;
        yield_productivity *= lambda;
    }
}
