using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

// UI类：所有UI组件的根节点
// 外观模式：为操纵UI组件提供统一的接口
public class UI : UI_Component
{
    
    // Asset
    public Panel_Asset panel_asset;
    public Label_Population_Stock label_population_stock;
    public Label_Population_Increment label_population_increment;
    public Label_Accommodation label_accommodation;
    public Label_Food_Stock label_food_stock;
    public Label_Food_Increment label_food_increment;
    public Label_Gold_Stock label_gold_stock;
    public Label_Gold_Increment label_gold_increment;
    public Label_Wood label_wood;
    public Label_Stone label_stone;
    public Label_Copper label_copper;
    public Label_Iron label_iron;

    // Statistic
    public Panel_Statistic panel_statistic;
    public Label_Urbanization label_urbanization;
    public Label_Science label_science;
    public Label_Culture label_culture;
    public Label_Commercialization label_commercialization;
    public Label_Productivity label_productivity;
    public Label_Electricity label_electricity;
    public Label_Military_Power label_military_power;
    public Label_Happiness label_happiness;
    public Label_Pollutation label_pollutation;

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
        int count = 25; // 游戏UI中的label数
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
                // asset
                case 1: return ui.label_population_stock;
                case 2: return ui.label_population_increment;
                case 3: return ui.label_accommodation;
                case 4: return ui.label_food_stock;
                case 5: return ui.label_food_increment;
                case 6: return ui.label_gold_stock;
                case 7: return ui.label_gold_increment;
                case 8: return ui.label_wood;
                case 9: return ui.label_stone;
                case 10: return ui.label_copper;
                case 11: return ui.label_iron;

                // statistic
                case 12: return ui.label_urbanization;
                case 13: return ui.label_science;
                case 14: return ui.label_culture;
                case 15: return ui.label_commercialization;
                case 16: return ui.label_productivity;
                case 17: return ui.label_electricity;
                case 18: return ui.label_military_power;
                case 19: return ui.label_happiness;
                case 20: return ui.label_pollutation;

                // control
                case 21: return ui.label_cellinfo;
                case 22: return ui.label_featureinfo;
                case 23: return ui.label_resourceinfo;
                case 24: return ui.label_zoneinfo;
                case 25: return ui.label_buildinginfo;
                default: return null;
            }
        }

        public void reset()
        {
            index = 0;
        }
    }

    // 访问者模式的根节点的accept()方法，遍历label组件调用其update_info()方法
    public override void update_info(UI_Updater updater)
    {
        for(Iterator iterator = new Label_Iterator(this); iterator.hasNext(); )
        {
            UI_Component label = (UI_Component)iterator.next();
            label.update_info(updater);
        }
    }
}
