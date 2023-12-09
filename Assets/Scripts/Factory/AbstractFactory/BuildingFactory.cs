using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 抽象工厂模式：建筑工厂基类。每个区域种类，调用对应的方法，通过建筑类型字符串获取建筑
public abstract class BuildingFactory
{
    public abstract Building getResidentialBuilding(string buildingType);
    public abstract Building getAgriculturalBuilding(string buildingType);
    public abstract Building getAcademicBuilding(string buildingType);
    public abstract Building getCommercialBuilding(string buildingType);
    public abstract Building getIndustrialBuilding(string buildingType);
    public abstract Building getLeisureBuilding(string buildingType);
    public abstract Building getMilitaryBuilding(string buildingType);
}
