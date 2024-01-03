using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;

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
    public Label_Pollution label_pollution;

    // Minimap
    public Minimap minimap;

    // Settings
    public Button_Settings button_settings;

    // Control
    public Cell cell; // 当前选中的单元格

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

        public UI_Component next()
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
                case 20: return ui.label_pollution;

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
            UI_Component label = iterator.next();
            label.update_info(updater);
        }
    }

    private void Start() {
        // 初始化所有UI组件
        panel_asset = transform.Find("Panel_Asset").gameObject.GetComponent<Panel_Asset>();
        label_population_stock = transform.Find("Panel_Asset/Label_Population_Stock").gameObject.GetComponent<Label_Population_Stock>();
        label_population_increment = transform.Find("Panel_Asset/Label_Population_Increment").gameObject.GetComponent<Label_Population_Increment>();
        label_accommodation = transform.Find("Panel_Asset/Label_Accommodation").gameObject.GetComponent<Label_Accommodation>();
        label_food_stock = transform.Find("Panel_Asset/Label_Food_Stock").gameObject.GetComponent<Label_Food_Stock>();
        label_food_increment = transform.Find("Panel_Asset/Label_Food_Increment").gameObject.GetComponent<Label_Food_Increment>();
        label_gold_stock = transform.Find("Panel_Asset/Label_Gold_Stock").gameObject.GetComponent<Label_Gold_Stock>();
        label_gold_increment = transform.Find("Panel_Asset/Label_Gold_Increment").gameObject.GetComponent<Label_Gold_Increment>();
        label_wood = transform.Find("Panel_Asset/Label_Wood").gameObject.GetComponent<Label_Wood>();
        label_stone = transform.Find("Panel_Asset/Label_Stone").gameObject.GetComponent<Label_Stone>();
        label_copper = transform.Find("Panel_Asset/Label_Copper").gameObject.GetComponent<Label_Copper>();
        label_iron = transform.Find("Panel_Asset/Label_Iron").gameObject.GetComponent<Label_Iron>();

        panel_statistic = transform.Find("Panel_Statistic").gameObject.GetComponent<Panel_Statistic>();
        label_urbanization = transform.Find("Panel_Statistic/Label_Urbanization").gameObject.GetComponent<Label_Urbanization>();
        label_science = transform.Find("Panel_Statistic/Label_Science").gameObject.GetComponent<Label_Science>();
        label_culture = transform.Find("Panel_Statistic/Label_Culture").gameObject.GetComponent<Label_Culture>();
        label_commercialization = transform.Find("Panel_Statistic/Label_Commercialization").gameObject.GetComponent<Label_Commercialization>();
        label_productivity = transform.Find("Panel_Statistic/Label_Productivity").gameObject.GetComponent<Label_Productivity>();
        label_electricity = transform.Find("Panel_Statistic/Label_Electricity").gameObject.GetComponent<Label_Electricity>();
        label_military_power = transform.Find("Panel_Statistic/Label_Military_Power").gameObject.GetComponent<Label_Military_Power>();
        label_happiness = transform.Find("Panel_Statistic/Label_Happiness").gameObject.GetComponent<Label_Happiness>();
        label_pollution = transform.Find("Panel_Statistic/Label_Pollution").gameObject.GetComponent<Label_Pollution>();

        panel_control = transform.Find("Panel_Control").gameObject.GetComponent<Panel_Control>();
        label_cellinfo = transform.Find("Panel_Control/Label_CellInfo").gameObject.GetComponent<Label_CellInfo>();
        label_featureinfo = transform.Find("Panel_Control/Label_FeatureInfo").gameObject.GetComponent<Label_FeatureInfo>();
        label_resourceinfo = transform.Find("Panel_Control/Label_ResourceInfo").gameObject.GetComponent<Label_ResourceInfo>();
        label_zoneinfo = transform.Find("Panel_Control/Label_ZoneInfo").gameObject.GetComponent<Label_ZoneInfo>();
        label_buildinginfo = transform.Find("Panel_Control/Label_BuildingInfo").gameObject.GetComponent<Label_BuildingInfo>();
        
        button_removefeature = transform.Find("Panel_Control/Button_RemoveFeature").gameObject.GetComponent<Button_RemoveFeature>();
        button_harvestresource = transform.Find("Panel_Control/Button_HarvestResource").gameObject.GetComponent<Button_HarvestResource>();
        button_constructzone = transform.Find("Panel_Control/Button_ConstructZone").gameObject.GetComponent<Button_ConstructZone>();
        button_constructbuilding = transform.Find("Panel_Control/Button_ConstructBuilding").gameObject.GetComponent<Button_ConstructBuilding>();
        button_demolish = transform.Find("Panel_Control/Button_Demolish").gameObject.GetComponent<Button_Demolish>();
        button_afforest = transform.Find("Panel_Control/Button_Afforest").gameObject.GetComponent<Button_Afforest>();

        // 为控制面板的按钮添加事件
        // button_afforest.gameObject.GetComponent<Button>().onClick.AddListener(cell.Afforest);
        // button_demolish.gameObject.GetComponent<Button>().onClick.AddListener(cell.Demolish);
        // button_removefeature.gameObject.GetComponent<Button>().onClick.AddListener(cell.RemoveFeature);
        // button_harvestresource.gameObject.GetComponent<Button>().onClick.AddListener(cell.HarvestResource);

        // 初始隐藏控制面板
        panel_control.gameObject.SetActive(false);

        update_info(new UI_Updater());
    }

    public string cell_info = "";
    public string feature_info = "";
    public string resource_info = "";
    public string zone_info = "";
    public string building_info = "";

    public void selectCell(Cell cell)
    {
        cell_info = "";
        feature_info = "";
        resource_info = "";
        zone_info = "";
        building_info = "";

        panel_control.gameObject.SetActive(true);

        this.cell = cell;
        cell_info = cell.state.ToString();
        if (cell.feature != null)
            feature_info = cell.feature.GetType().ToString();
        if (cell.resource != null)
            resource_info = cell.resource.GetType().ToString();
        if (cell.zone != null)
            zone_info = cell.zone.GetType().ToString();
        if (cell.buildings != null)
            building_info = cell.buildings.ToString();

        update_info(new UI_Updater());
    }
}
