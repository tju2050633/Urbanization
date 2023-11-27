using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// UI类：所有UI组件的根节点
// 外观模式：为操纵UI组件提供统一的接口
public class UI : UI_Component
{
    
    // Asset
    public Panel_Asset panel_asset;
    public Label_Asset label_asset;

    // Statistic
    public Panel_Statistic panel_statistic;
    public Label_Statistic label_statistic;

    // Minimap
    public Minimap minimap;

    // Settings
    public Button_Settings button_settings;

    // Control
    public Panel_Control panel_control;
    public Label_CellInfo label_cellinfo;
    public Label_FeatureInfo label_featureinfo;
    public Button_RemoveFeature button_removefeature;
    public Label_ResourceInfo label_resourceinfo;
    public Button_HarvestResource button_harvestresource;
    public Label_ZoneInfo label_zoneinfo;
    public Button_ConstructZone button_constructzone;
    public Label_BuildingInfo label_buildinginfo;
    public Button_ConstructBuilding button_constructbuilding; // TODO:有多种建筑，按钮个数需要根据区域类型生成
    public Button_Demolish button_demolish;
    public Button_Afforest button_afforest;

    // 迭代器模式：迭代器，帮助UI根节点遍历label组件
    private class Label_Iterator : Iterator
    {
        int index = 0;
        int count = 7; // 游戏UI中的label数
        UI ui;
        public Label_Iterator(UI ui)
        {
            this.ui = ui;
        }

        public bool hasNext()
        {
            return index < count;
        }

        public object next()
        {
            index++;
            switch (index)
            {
                case 1: return ui.label_asset;
                case 2: return ui.label_statistic;
                case 3: return ui.label_cellinfo;
                case 4: return ui.label_featureinfo;
                case 5: return ui.label_resourceinfo;
                case 6: return ui.label_zoneinfo;
                case 7: return ui.label_buildinginfo;
                default: return null;
            }
        }

        public void reset()
        {
            index = 0;
        }
    }

    // 访问者模式的根节点的accept()方法，遍历label组件调用其update_info()方法
    public override void update_info()
    {
        for(Iterator iterator = new Label_Iterator(this); iterator.hasNext(); )
        {
            UI_Component label = (UI_Component)iterator.next();
            label.update_info();
        }
    }

    // 每秒更新增量带来的UI变化
    public void increaseStock()
    {
    }
}
