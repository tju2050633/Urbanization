using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 单例模式
public class Cache_Terrain : ICache
{
    private static Cache_Terrain _instance = new Cache_Terrain();
    private Cache_Terrain() { }
    public static Cache_Terrain getInstance()
    {
        _instance.terrainDict.Add("Flatlands", new Flatlands());
        _instance.terrainDict.Add("Hill", new Hill());
        _instance.terrainDict.Add("Water", new Water());

        return _instance;
    }

    Dictionary<string, Terrain> terrainDict = new Dictionary<string, Terrain>();

    public object getClone(string type)
    {
        if (!terrainDict.ContainsKey(type))
            return null;
        return terrainDict[type].Clone();
    }
}
