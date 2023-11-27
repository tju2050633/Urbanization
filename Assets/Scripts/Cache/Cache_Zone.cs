using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 单例模式
public class Cache_Zone : ICache
{
    private static Cache_Zone _instance = new Cache_Zone();
    private Cache_Zone() { }
    public static Cache_Zone getInstance()
    {
        _instance.zoneDict.Add("Residential", new Zone_Residential());
        _instance.zoneDict.Add("Agricultural", new Zone_Agricultural());

        return _instance;
    }

    Dictionary<string, Zone> zoneDict = new Dictionary<string, Zone>();

    public object getClone(string type)
    {
        if (!zoneDict.ContainsKey(type))
            return null;
        return zoneDict[type].Clone();
    }
}
