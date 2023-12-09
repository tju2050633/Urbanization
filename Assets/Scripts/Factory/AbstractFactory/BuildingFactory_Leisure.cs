using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 建筑工厂：娱乐区建筑工厂
public class BuildingFactory_Leisure : BuildingFactory
{
    public override Building getResidentialBuilding(string buildingType)
    {
        Debug.LogError("get***Building方法调用错误，检查工厂类型和方法名是否一致");
        return null;
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
        Building leisureBuilding;
        if (string.Equals(buildingType, "Theater", System.StringComparison.OrdinalIgnoreCase))
        {
            leisureBuilding = new Theater();
        }
        else if (string.Equals(buildingType, "Zoo", System.StringComparison.OrdinalIgnoreCase))
        {
            leisureBuilding = new Zoo();
        }
        else if (string.Equals(buildingType, "Stadium", System.StringComparison.OrdinalIgnoreCase))
        {
            leisureBuilding = new Stadium();
        }
        else if (string.Equals(buildingType, "Museum", System.StringComparison.OrdinalIgnoreCase))
        {
            leisureBuilding = new Museum();
        }
        else if (string.Equals(buildingType, "AmusementPark", System.StringComparison.OrdinalIgnoreCase))
        {
            leisureBuilding = new AmusementPark();
        }
        else if (string.Equals(buildingType, "NaturalPark", System.StringComparison.OrdinalIgnoreCase))
        {
            leisureBuilding = new NaturalPark();
        }
        else
        {
            Debug.LogError("建筑类型字符串错误：" + buildingType);
            return null;
        }

        // 应用装饰器模式
        return new Decorator_Pollution(new Decorator_Happiness(leisureBuilding));
    }

    public override Building getMilitaryBuilding(string buildingType)
    {
        Debug.LogError("get***Building方法调用错误，检查工厂类型和方法名是否一致");
        return null;
    }
}