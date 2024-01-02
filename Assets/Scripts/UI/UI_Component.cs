using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 组合模式：将UI对象（都继承UI_Component）组合成树形结构
// 访问者模式：UI_Component都是被访问者，UI根节点和label组件重写update_info()方法
public class UI_Component : MonoBehaviour   
{
    List<UI_Component> children = new List<UI_Component>();

    void Start()
    {
        // 找到所有子物体
        foreach (Transform child in transform)
        {
            UI_Component child_component = child.GetComponent<UI_Component>();
            if (child_component != null)
            {
                children.Add(child_component);
            }
        }
    }

    public virtual void render()
    {
        // 渲染自身
        gameObject.SetActive(true);

        // 渲染子节点
        foreach (UI_Component child in children)
        {
            child.render();
        }
    }

    public virtual void hide()
    {
        // 隐藏自身
        gameObject.SetActive(false);

        // 隐藏子节点
        foreach (UI_Component child in children)
        {
            child.hide();
        }
    }

    // 访问者模式的accept()方法
    public virtual void update_info(UI_Updater updater)
    {

    }
}
