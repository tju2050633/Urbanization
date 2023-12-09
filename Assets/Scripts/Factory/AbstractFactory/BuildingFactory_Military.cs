using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 建筑工厂：军事区建筑工厂
public class BuildingFactory_Military : BuildingFactory
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
        Debug.LogError("get***Building方法调用错误，检查工厂类型和方法名是否一致");
        return null;
    }

    public override Building getMilitaryBuilding(string buildingType)
    {
        Building militaryBuilding;
        if (string.Equals(buildingType, "Stable", System.StringComparison.OrdinalIgnoreCase))
        {
            militaryBuilding = new Stable();
        }
        else if (string.Equals(buildingType, "Barrack", System.StringComparison.OrdinalIgnoreCase))
        {
            militaryBuilding = new Barrack();
        }
        else if (string.Equals(buildingType, "Hangar", System.StringComparison.OrdinalIgnoreCase))
        {
            militaryBuilding = new Hangar();
        }
        else if (string.Equals(buildingType, "MilitaryBase", System.StringComparison.OrdinalIgnoreCase))
        {
            militaryBuilding = new MilitaryBase();
        }
        else
        {
            Debug.LogError("建筑类型字符串错误：" + buildingType);
            return null;
        }

        // 应用装饰器模式
        return new Decorator_Pollution(new Decorator_Happiness(militaryBuilding));
    }
}