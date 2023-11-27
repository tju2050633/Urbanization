using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 工厂模式：地形工厂
public class TerrainFactory
{
    public Terrain getTerrain(string terrainType)
    {
        return CacheFacade.getInstance().cloneTerrain(terrainType);
    }
}