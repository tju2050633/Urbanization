using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UI_Updater
{
    // 访问者模式：UI_Component都是被访问者，UI根节点和label组件重写update_info()方法
    public void update(UI_Component component, string info)
    {
        switch (info)
        {
            case "population_stock":
                component.gameObject.GetComponent<Label>().text = AssetManager.getInstance().Population_Stock.ToString();
                break;
            default:
                break;
        }
    }
}