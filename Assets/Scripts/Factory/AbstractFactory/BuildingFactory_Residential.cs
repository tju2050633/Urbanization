using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 建筑工厂：住宅区建筑工厂
public class BuildingFactory_Residential : BuildingFactory
{
    public override Building getResidentialBuilding(string buildingType)
    {
        Building residentialBuilding;
        if (string.Equals(buildingType, "Slum", System.StringComparison.OrdinalIgnoreCase))
        {
            residentialBuilding = new Slum();
        }
        else if (string.Equals(buildingType, "Bungalow", System.StringComparison.OrdinalIgnoreCase))
        {
            residentialBuilding = new Bungalow();
        }
        else if (string.Equals(buildingType, "Apartment", System.StringComparison.OrdinalIgnoreCase))
        {
            residentialBuilding = new Apartment();
        }
        else if (string.Equals(buildingType, "Skyscraper", System.StringComparison.OrdinalIgnoreCase))
        {
            residentialBuilding = new Skyscraper();
        }
        else if (string.Equals(buildingType, "Villa", System.StringComparison.OrdinalIgnoreCase))
        {
            residentialBuilding = new Villa();
        }
        else
        {
            Debug.LogError("建筑类型字符串错误：" + buildingType);
            return null;
        }

        // 应用装饰器模式
        return new Decorator_Pollution(new Decorator_Happiness(residentialBuilding));
    }

    public override Building getAgriculturalBuilding(string buildingType)
    {
        Debug.LogError("get***Building方法调用错误，检查工厂类型和方法名是否一致");
        return null;
    }

    public override Building getAcademicBuilding(string buildingType)
    {
        Debug.LogError("get***Building方法调用错误，检查工厂类型和方法名是否一致");
        return null;
    }

    public override Building getCommercialBuilding(string buildingType)
    {
        Debug.LogError("get***Building方法调用错误，检查工厂类型和方法名是否一致");
        return null;
    }

    public override Building getIndustrialBuilding(string buildingType)
    {
        Debug.LogError("get***Building方法调用错误，检查工厂类型和方法名是否一致");
        return null;
    }

    public override Building getLeisureBuilding(string buildingType)
    {
        Debug.LogError("get***Building方法调用错误，检查工厂类型和方法名是否一致");
        return null;
    }

    public override Building getMilitaryBuilding(string buildingType)
    {
        Debug.LogError("get***Building方法调用错误，检查工厂类型和方法名是否一致");
        return null;
    }
}
