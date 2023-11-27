using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 建筑工厂：农业区建筑工厂
public class BuildingFactory_Agricultural : BuildingFactory
{
    public override Building getResidentialBuilding(string buildingType)
    {
        Debug.LogError("get***Building方法调用错误，检查工厂类型和方法名是否一致");
        return null;
    }

    public override Building getAgriculturalBuilding(string buildingType)
    {
        Building agriculturalBuilding;
        if (string.Equals(buildingType, "Granary", System.StringComparison.OrdinalIgnoreCase))
        {
            agriculturalBuilding =  new Granary();
        }
        else if (string.Equals(buildingType, "Farm", System.StringComparison.OrdinalIgnoreCase))
        {
            agriculturalBuilding =  new Farm();
        }
        else if (string.Equals(buildingType, "Orchard", System.StringComparison.OrdinalIgnoreCase))
        {
            agriculturalBuilding =  new Orchard();
        }
        else if (string.Equals(buildingType, "Ranche", System.StringComparison.OrdinalIgnoreCase))
        {
            agriculturalBuilding =  new Ranche();
        }
        else if (string.Equals(buildingType, "MechanizedFarm", System.StringComparison.OrdinalIgnoreCase))
        {
            agriculturalBuilding =  new MechanizedFarm();
        }
        else if (string.Equals(buildingType, "MechanizedOrchard", System.StringComparison.OrdinalIgnoreCase))
        {
            agriculturalBuilding =  new MechanizedOrchard();
        }
        else if (string.Equals(buildingType, "MechanizedRanche", System.StringComparison.OrdinalIgnoreCase))
        {
            agriculturalBuilding =  new MechanizedRanche();
        }
        else
        {
            Debug.LogError("建筑类型字符串错误：" + buildingType);
            return null;
        }

        // 应用装饰器模式
        return new Decorator_Pollution(new Decorator_Happiness(agriculturalBuilding));
    }
}
