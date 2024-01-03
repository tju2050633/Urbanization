using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class UI_Updater
{
    // 访问者模式：UI_Component都是被访问者，UI根节点和label组件重写update_info()方法
    public void update(UI_Component component, string info)
    {
        switch (info)
        {
            case "population_stock":
                component.gameObject.GetComponent<Text>().text = AssetManager.getInstance().Population_Stock.ToString();
                break;
            case "population_increment":
                component.gameObject.GetComponent<Text>().text = AssetManager.getInstance().Population_Increment.ToString();
                break;
            case "accommodation":
                component.gameObject.GetComponent<Text>().text = AssetManager.getInstance().Accommodation_Stock.ToString();
                break;
            case "food_stock":
                component.gameObject.GetComponent<Text>().text = AssetManager.getInstance().Food_Stock.ToString();
                break;
            case "food_increment":
                component.gameObject.GetComponent<Text>().text = AssetManager.getInstance().Food_Increment.ToString();
                break;
            case "gold_stock":
                component.gameObject.GetComponent<Text>().text = AssetManager.getInstance().Gold_Stock.ToString();
                break;
            case "gold_increment":
                component.gameObject.GetComponent<Text>().text = AssetManager.getInstance().Gold_Increment.ToString();
                break;
            case "wood":
                component.gameObject.GetComponent<Text>().text = AssetManager.getInstance().Wood_Stock.ToString();
                break;
            case "stone":
                component.gameObject.GetComponent<Text>().text = AssetManager.getInstance().Stone_Stock.ToString();
                break;
            case "copper":
                component.gameObject.GetComponent<Text>().text = AssetManager.getInstance().Copper_Stock.ToString();
                break;
            case "iron":
                component.gameObject.GetComponent<Text>().text = AssetManager.getInstance().Iron_Stock.ToString();
                break;
            case "urbanization":
                component.gameObject.GetComponent<Text>().text = StatisticManager.getInstance().Urbanization.ToString();
                break;
            case "science":
                component.gameObject.GetComponent<Text>().text = StatisticManager.getInstance().Science_Level.ToString();
                break;
            case "culture":
                component.gameObject.GetComponent<Text>().text = StatisticManager.getInstance().Culture_Level.ToString();
                break;
            case "commercialization":
                component.gameObject.GetComponent<Text>().text = StatisticManager.getInstance().Commercialization.ToString();
                break;
            case "productivity":
                component.gameObject.GetComponent<Text>().text = StatisticManager.getInstance().Productivity.ToString();
                break;
            case "electricity":
                component.gameObject.GetComponent<Text>().text = StatisticManager.getInstance().Electricity.ToString();
                break;
            case "military_power":
                component.gameObject.GetComponent<Text>().text = StatisticManager.getInstance().MilitaryPower.ToString();
                break;
            case "happiness":
                component.gameObject.GetComponent<Text>().text = StatisticManager.getInstance().Happiness.ToString();
                break;
            case "pollution":
                component.gameObject.GetComponent<Text>().text = StatisticManager.getInstance().Pollution.ToString();
                break;
            case "cell_info":
                component.gameObject.transform.Find("text").GetComponent<TextMeshProUGUI>().text = GameObject.Find("Canvas").GetComponent<UI>().cell_info;
                break;
            case "feature_info":
                component.gameObject.transform.Find("text").GetComponent<TextMeshProUGUI>().text = GameObject.Find("Canvas").GetComponent<UI>().feature_info;
                break;
            case "resource_info":
                component.gameObject.transform.Find("text").GetComponent<TextMeshProUGUI>().text = GameObject.Find("Canvas").GetComponent<UI>().resource_info;
                break;
            case "zone_info":
                component.gameObject.transform.Find("text").GetComponent<TextMeshProUGUI>().text = GameObject.Find("Canvas").GetComponent<UI>().zone_info;
                break;
            case "building_info":
                component.gameObject.transform.Find("text").GetComponent<TextMeshProUGUI>().text = GameObject.Find("Canvas").GetComponent<UI>().building_info;
                break;
            default:
                break;
        }
    }
}