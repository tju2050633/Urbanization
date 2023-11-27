using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 备忘录类
// 备忘录模式：实现游戏存档和读档功能
[Serializable]
public class Memento
{
    // 城市资源
    float Population_Stock;
    float Population_Increment;
    float Accommodation_Stock;
    float Food_Stock;
    float Food_Increment;
    float Gold_Stock;
    float Gold_Increment;
    float Wood_Stock;
    float Stone_Stock;
    float Copper_Stock;
    float Iron_Stock;

    // 城市统计信息
    float Urbanization;
    float Science_Level;
    float Culture_Level;
    float Commercialization;
    float Productivity;
    float Electricity;
    float MilitaryPower;
    float Happiness;
    float Pollutation;

    // 单元格信息


    // 将游戏数据存入备忘录对象
    public void saveGameToMemento()
    {
        Population_Stock = AssetManager.getInstance().Population_Stock;
        Population_Increment = AssetManager.getInstance().Population_Increment;
        Accommodation_Stock = AssetManager.getInstance().Accommodation_Stock;
        Food_Stock = AssetManager.getInstance().Food_Stock;
        Food_Increment = AssetManager.getInstance().Food_Increment;
        Gold_Stock = AssetManager.getInstance().Gold_Stock;
        Gold_Increment = AssetManager.getInstance().Gold_Increment;
        Wood_Stock = AssetManager.getInstance().Wood_Stock;
        Stone_Stock = AssetManager.getInstance().Stone_Stock;
        Copper_Stock = AssetManager.getInstance().Copper_Stock;
        Iron_Stock = AssetManager.getInstance().Iron_Stock;

        Urbanization = StatisticManager.getInstance().Urbanization;
        Science_Level = StatisticManager.getInstance().Science_Level;
        Culture_Level = StatisticManager.getInstance().Culture_Level;
        Commercialization = StatisticManager.getInstance().Commercialization;
        Productivity = StatisticManager.getInstance().Productivity;
        Electricity = StatisticManager.getInstance().Electricity;
        MilitaryPower = StatisticManager.getInstance().MilitaryPower;
        Happiness = StatisticManager.getInstance().Happiness;
        Pollutation = StatisticManager.getInstance().Pollution;
    }

    // 从备忘录对象读取游戏数据
    public void loadGameFromMemento()
    {
        AssetManager.getInstance().Population_Stock = Population_Stock;
        AssetManager.getInstance().Population_Increment = Population_Increment;
        AssetManager.getInstance().Accommodation_Stock = Accommodation_Stock;
        AssetManager.getInstance().Food_Stock = Food_Stock;
        AssetManager.getInstance().Food_Increment = Food_Increment;
        AssetManager.getInstance().Gold_Stock = Gold_Stock;
        AssetManager.getInstance().Gold_Increment = Gold_Increment;
        AssetManager.getInstance().Wood_Stock = Wood_Stock;
        AssetManager.getInstance().Stone_Stock = Stone_Stock;
        AssetManager.getInstance().Copper_Stock = Copper_Stock;
        AssetManager.getInstance().Iron_Stock = Iron_Stock;

        StatisticManager.getInstance().Urbanization = Urbanization;
        StatisticManager.getInstance().Science_Level = Science_Level;
        StatisticManager.getInstance().Culture_Level = Culture_Level;
        StatisticManager.getInstance().Commercialization = Commercialization;
        StatisticManager.getInstance().Productivity = Productivity;
        StatisticManager.getInstance().Electricity = Electricity;
        StatisticManager.getInstance().MilitaryPower = MilitaryPower;
        StatisticManager.getInstance().Happiness = Happiness;
        StatisticManager.getInstance().Pollution = Pollutation;
    }
}
