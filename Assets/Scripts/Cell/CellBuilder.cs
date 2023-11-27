using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 建造者模式：单元格建造者
// 初始单元格具有地形、地貌、资源三个可拓展类型的属性，可组合成多种单元格
// 通过建造者模式，将单元格的组合过程与单元格本身分离，使得单元格的组合过程更加灵活
public class CellBuilder
{
    Terrain findTerrain(GameObject gameObject)
    {
        return new TerrainFactory().getTerrain(gameObject.name);
    }

    Feature findFeature(GameObject gameObject)
    {
        Feature feature = null;
        foreach (Transform child in gameObject.transform)
        {
            feature = new FeatureFactory().getFeature(child.gameObject.name);
        }
        return feature;
    }

    Resource findResource(GameObject gameObject)
    {
        Resource resource = null;
        foreach (Transform child in gameObject.transform)
        {
            resource = new ResourceFactory().getResource(child.gameObject.name);
        }
        return resource;
    }

    State findState(Cell cell, Feature feature, Resource resource)
    {
        if(feature != null && resource != null)
        {
            return new State_Feature_Resource(cell);
        }
        else if(feature != null)
        {
            return new State_Feature(cell);
        }
        else if(resource != null)
        {
            return new State_Resource(cell);
        }
        else
        {
            return new State_Undeveloped(cell);
        }
    }

    // 检查地形、地貌、资源是否匹配
    bool checkCell(Terrain terrain, Feature feature, Resource resource)
    {
        if(terrain == null)
        {
            Debug.Log("地形为空");
            return false;
        }
        if(feature != null && !terrain.featureList.Contains(feature.GetType().Name.ToString()))
        {
            Debug.Log("地形与地貌不匹配");
            return false;
        }
        if(resource != null && !terrain.resourceList.Contains(resource.GetType().Name.ToString()))
        {
            Debug.Log("地形与资源不匹配");
            return false;
        }
        return true;
    }

    public Cell build(GameObject gameObject)
    {
        Terrain terrain = findTerrain(gameObject);
        Feature feature = findFeature(gameObject);
        Resource resource = findResource(gameObject);
        if(!checkCell(terrain, feature, resource))
        {
            Debug.Log("单元格建造失败");
            return null;
        }

        Cell cell = new Cell(null, terrain, feature, resource);

        State state = findState(cell, feature, resource);
        cell.state = state;

        return cell;
    }
}
