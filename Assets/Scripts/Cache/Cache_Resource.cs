using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 单例模式
public class Cache_Resource : ICache
{
    private static Cache_Resource _instance = new Cache_Resource();
    private Cache_Resource() { }
    public static Cache_Resource getInstance()
    {
        _instance.resourceDict.Add("Copper", new Copper());
        _instance.resourceDict.Add("Iron", new Iron());
        _instance.resourceDict.Add("Gold", new Gold());

        _instance.resourceDict.Add("Horse", new Horse());
        _instance.resourceDict.Add("Pig", new Pig());
        _instance.resourceDict.Add("Sheep", new Sheep());

        _instance.resourceDict.Add("Fish", new Fish());
        _instance.resourceDict.Add("Crab", new Crab());
        _instance.resourceDict.Add("Pearl", new Pearl());

        return _instance;
    }

    Dictionary<string, Resource> resourceDict = new Dictionary<string, Resource>();

    public object getClone(string type)
    {
        if (!resourceDict.ContainsKey(type))
            return null;
        return resourceDict[type].Clone();
    }
}
