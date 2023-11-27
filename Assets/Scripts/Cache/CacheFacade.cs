using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 缓存系统外观类
// 外观模式：缓存外观，提供统一的接口。外部类使用缓存系统，只需要调用外观类的接口。
public class CacheFacade
{
    private static CacheFacade _instance = new CacheFacade();
    private CacheFacade() { }
    public static CacheFacade getInstance()
    {
        return _instance;
    }

    ICache cache_zone = Cache_Zone.getInstance();
    ICache cache_feature = Cache_Feature.getInstance();
    ICache cache_resource = Cache_Resource.getInstance();
    ICache cache_terrain = Cache_Terrain.getInstance();

    public Zone cloneZone(string zoneType)
    {
        return (Zone)cache_zone.getClone(zoneType);
    }

    public Feature cloneFeature(string featureType)
    {
        return (Feature)cache_feature.getClone(featureType);
    }

    public Resource cloneResource(string resourceType)
    {
        return (Resource)cache_resource.getClone(resourceType);
    }

    public Terrain cloneTerrain(string terrainType)
    {
        return (Terrain)cache_terrain.getClone(terrainType);
    }
}
