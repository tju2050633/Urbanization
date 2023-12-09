using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 建筑工厂：工业区建筑工厂
public class BuildingFactory_Industrial : BuildingFactory
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
        Building industrialBuilding;
        if (string.Equals(buildingType, "Workshop", System.StringComparison.OrdinalIgnoreCase))
        {
            industrialBuilding = new Workshop();
        }
        else if (string.Equals(buildingType, "Factory", System.StringComparison.OrdinalIgnoreCase))
        {
            industrialBuilding = new Factory();
        }
        else if (string.Equals(buildingType, "ElectronicsFactory", System.StringComparison.OrdinalIgnoreCase))
        {
            industrialBuilding = new ElectronicsFactory();
        }
        else if (string.Equals(buildingType, "MilitaryFactory", System.StringComparison.OrdinalIgnoreCase))
        {
            industrialBuilding = new MilitaryFactory();
        }
        else if (string.Equals(buildingType, "ThermalPowerPlant", System.StringComparison.OrdinalIgnoreCase))
        {
            industrialBuilding = new ThermalPowerPlant();
        }
        else if (string.Equals(buildingType, "NuclearPowerPlant", System.StringComparison.OrdinalIgnoreCase))
        {
            industrialBuilding = new NuclearPowerPlant();
        }
        else
        {
            Debug.LogError("建筑类型字符串错误：" + buildingType);
            return null;
        }

        // 应用装饰器模式
        return new Decorator_Pollution(new Decorator_Happiness(industrialBuilding));
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