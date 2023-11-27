using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 适配器模式：MementoManager本身默认处理JSON文件，但可通过持有XMLAdapter对象，实现对XML文件的处理
public class XMLAdapter : IFileHandler
{
    public void save(string fileName, string fileType)
    {
        string file = fileName + ".xml";

        // 创建备忘录，保存游戏数据
        Memento memento = new Memento();
        memento.saveGameToMemento();

        // 保存备忘录XML文件
        string xml = XMLUtility.ToXml(memento);
        System.IO.File.WriteAllText(file, xml);
    }

    public void load(string fileName, string fileType)
    {
        string file = fileName + ".xml";


        // 读取备忘录XML文件
        string xml = System.IO.File.ReadAllText(file);
        Memento memento = XMLUtility.FromXml<Memento>(xml);

        // 读取游戏数据
        memento.loadGameFromMemento();
    }

    public void delete(string fileName, string fileType)
    {
        string file = fileName + ".xml";
        System.IO.File.Delete(file);
    }
}