using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 建筑工厂：商业区建筑工厂
public class BuildingFactory_Commercial : BuildingFactory
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
        Building commercialBuilding;
        if (string.Equals(buildingType, "Market", System.StringComparison.OrdinalIgnoreCase))
        {
            commercialBuilding = new Market();
        }
        else if (string.Equals(buildingType, "Bank", System.StringComparison.OrdinalIgnoreCase))
        {
            commercialBuilding = new Bank();
        }
        else if (string.Equals(buildingType, "Company", System.StringComparison.OrdinalIgnoreCase))
        {
            commercialBuilding = new Company();
        }
        else if (string.Equals(buildingType, "StockExchange", System.StringComparison.OrdinalIgnoreCase))
        {
            commercialBuilding = new StockExchange();
        }
        else if (string.Equals(buildingType, "FinancialCenter", System.StringComparison.OrdinalIgnoreCase))
        {
            commercialBuilding = new FinancialCenter();
        }
        else
        {
            Debug.LogError("建筑类型字符串错误：" + buildingType);
            return null;
        }

        // 应用装饰器模式
        return new Decorator_Pollution(new Decorator_Happiness(commercialBuilding));
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