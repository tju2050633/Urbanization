using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 建筑工厂：学院区建筑工厂
public class BuildingFactory_Academic : BuildingFactory
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
        Building academicBuilding;
        if (string.Equals(buildingType, "PrimarySchool", System.StringComparison.OrdinalIgnoreCase))
        {
            academicBuilding = new PrimarySchool();
        }
        else if (string.Equals(buildingType, "MiddleSchool", System.StringComparison.OrdinalIgnoreCase))
        {
            academicBuilding = new MiddleSchool();
        }
        else if (string.Equals(buildingType, "University", System.StringComparison.OrdinalIgnoreCase))
        {
            academicBuilding = new University();
        }
        else if (string.Equals(buildingType, "MilitaryCollege", System.StringComparison.OrdinalIgnoreCase))
        {
            academicBuilding = new MilitaryCollege();
        }
        else if (string.Equals(buildingType, "Library", System.StringComparison.OrdinalIgnoreCase))
        {
            academicBuilding = new Library();
        }
        else if (string.Equals(buildingType, "ResearchInstitute", System.StringComparison.OrdinalIgnoreCase))
        {
            academicBuilding = new ResearchInstitute();
        }
        else
        {
            Debug.LogError("建筑类型字符串错误：" + buildingType);
            return null;
        }

        // 应用装饰器模式
        return new Decorator_Pollution(new Decorator_Happiness(academicBuilding));
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