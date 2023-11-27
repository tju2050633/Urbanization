using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 单例模式：管理所有统计信息
public class StatisticManager
{
    private static StatisticManager _instance = new StatisticManager();
    private StatisticManager() { }
    public static StatisticManager getInstance()
    {
        return _instance;
    }

    // 城市的统计信息Statistic，为所有已开发单元格相应属性之和
    public float Urbanization = 0;
    public float Science_Level = 0;
    public float Culture_Level = 0;
    public float Commercialization = 0;
    public float Productivity = 0;
    public float Electricity = 0;
    public float MilitaryPower = 0;
    public float Happiness = 0;
    public float Pollution = 0;
}
