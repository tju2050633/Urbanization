using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 桥接模式：单元格对象持有地形、地貌、资源三个可拓展类型的属性
// 观察者模式：单元格是被观察者，建筑是观察者
public class Cell : MonoBehaviour
{
    // 持有对象
    public State state;
    public Terrain terrain;
    public Feature feature;
    public Resource resource;
    public Zone zone = null;
    public Dictionary<string, (int, int, List<Building>)> buildings; // 存建筑信息：字典结构，key=建筑类型，value=(已建数量，上限，建筑对象列表)

    // 属性
    public float food = 0;
    public float accommodation = 0;
    public float gold = 0;
    public float science = 0;
    public float culture = 0;
    public float commercialization = 0;
    public float productivity = 0;
    public float electricity = 0;
    public float military = 0;
    public float happiness = 0;
    public float pollution = 0;

    private void ResetProperties()
    {
        food = 0;
        accommodation = 0;
        gold = 0;
        science = 0;
        culture = 0;
        commercialization = 0;
        productivity = 0;
        electricity = 0;
        military = 0;
        happiness = 0;
        pollution = 0;
    }

    // 默认构造函数，用于Unity序列化
    public Cell()
    {

    }

    // 构造函数，便于CellBuilder构造对象
    public Cell(State state, Terrain terrain, Feature feature, Resource resource)
    {
        this.state = state;
        this.terrain = terrain;
        this.feature = feature;
        this.resource = resource;
    }

    // 建造者模式：将构造对象的逻辑委托给CellBuilder
    void Awake() 
    {
        Cell cell = new CellBuilder().build(gameObject);
       
        terrain = cell.terrain;
        feature = cell.feature;
        resource = cell.resource;
        state = cell.state;
        state.cell = this;  // 改变原cell对象中state的引用
    }

    public void RemoveFeature()
    {
        state.RemoveFeature();
        feature = null;
    }

    public void HarvestResource()
    {
        state.HarvestResource();
        resource = null;
    }

    public void BuildZone(Zone zone)
    {
        state.BuildZone();
        this.zone = zone;

        // 根据区域类型初始化建筑字典
        buildings = zone.getBuildingDictionary();
    }

    public void BuildBuilding(Building building)
    {
        string buildingType = building.GetType().ToString();
        buildings[buildingType] = (buildings[buildingType].Item1 + 1, buildings[buildingType].Item2, buildings[buildingType].Item3);
        buildings[buildingType].Item3.Add(building);

        building.yield();
    }

    public void Demolish()
    {
        state.Demolish();
        zone = null;
        buildings.Clear();

        ResetProperties();
    }

    public void Afforest()
    {
        state.Afforest();
        feature = new FeatureFactory().getFeature("Woods");
    }

    public List<Cell> getNeighborCells(int distance)
    {
        // TODO: 从地图中获取距离≤distance的所有单元格
        return new List<Cell>();
    }

    // 观察者模式：当单元格（被观察者）某些属性发生变化、可能产生额外增减益时，
    // 调用此方法让其中所有建筑（观察者）重新计算属性
    public void Recaculate()
    {
        if(state is not State_Developed)
        {
            Debug.LogError("单元格未开发，无法重新计算属性");
            return;
        }

        ResetProperties();

        foreach(var buildingList in buildings.Values)
        {
            foreach(var building in buildingList.Item3)
            {
                building.yield(false); // 防止无限递归
            }
        }
    }
}
