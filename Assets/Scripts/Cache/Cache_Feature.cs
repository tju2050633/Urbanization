using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 单例模式
public class Cache_Feature : ICache
{
    private static Cache_Feature _instance = new Cache_Feature();
    private Cache_Feature() { }
    public static Cache_Feature getInstance()
    {
        _instance.featureDict.Add("Rainforest", new Rainforest());
        _instance.featureDict.Add("Stone", new Stone());
        _instance.featureDict.Add("Woods", new Woods());

        return _instance;
    }

    Dictionary<string, Feature> featureDict = new Dictionary<string, Feature>();

    public object getClone(string type)
    {
        if (!featureDict.ContainsKey(type))
            return null;
        return featureDict[type].Clone();
    }
}
