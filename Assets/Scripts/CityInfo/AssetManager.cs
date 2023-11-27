using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 单例模式：管理所有资源
public class AssetManager
{
    private static AssetManager _instance = new AssetManager();
    private AssetManager() { }
    public static AssetManager getInstance()
    {
        return _instance;
    }

    // 城市的资源Asset，Stock存量，Increment增量
    public float Population_Stock = 0;
    public float Population_Increment = 0;
    public float Accommodation_Stock = 0;
    public float Food_Stock = 0;
    public float Food_Increment = 0;
    public float Gold_Stock = 0;
    public float Gold_Increment = 0;
    public float Wood_Stock = 0;
    public float Stone_Stock = 0;
    public float Copper_Stock = 0;
    public float Iron_Stock = 0;

    public void Add_Stock(float population, float accommodation, float food, float gold, float wood, float stone, float copper, float iron)
    {
        Population_Stock += population;
        Accommodation_Stock += accommodation;
        Food_Stock += food;
        Gold_Stock += gold;
        Wood_Stock += wood;
        Stone_Stock += stone;
        Copper_Stock += copper;
        Iron_Stock += iron;

        // TODO：更新UI
    }

}