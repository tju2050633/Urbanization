using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 备忘录管理器，提供对备忘录的管理接口
// 单例模式
// 适配器模式：使用XML适配器处理.xml格式需求
public class MementoManager : IFileHandler
{
    private static MementoManager _instance = new MementoManager();
    private MementoManager() { }
    public static MementoManager getInstance()
    {
        return _instance;
    }

    XMLAdapter xmlAdapter;

    public List<string> fileNameList = new List<string>();

    public void save(string fileName, string fileType)
    {
        // 覆盖同名存档
        if (fileNameList.Contains(fileName))
        {
            fileNameList.Remove(fileName);
            System.IO.File.Delete(fileName);
        }

        // 添加存档名
        fileNameList.Add(fileName);

        // 只支持JSON和XML格式
        if (fileType != "json" && fileType != "xml")
        {
            Debug.Log("文件类型不支持");
            return;
        }
        else if (fileName == "xml")
        {
            // 使用XML适配器对象
            xmlAdapter = new XMLAdapter();
            xmlAdapter.save(fileName, fileType);

            return;
        }

        string file = fileName + ".json";

        // 创建备忘录，保存游戏数据
        Memento memento = new Memento();
        memento.saveGameToMemento();

        // 保存备忘录JSON文件
        string json = JsonUtility.ToJson(memento);
        System.IO.File.WriteAllText(file, json);
    }

    public void load(string fileName, string fileType)
    {
        // 存档不存在
        if (!fileNameList.Contains(fileName))
        {
            Debug.Log("存档不存在");
            return;
        }

        // 只支持JSON和XML格式
        if (fileType != "json" && fileType != "xml")
        {
            Debug.Log("文件类型不支持");
            return;
        }
        else if (fileName == "xml")
        {
            // 使用XML适配器对象
            xmlAdapter = new XMLAdapter();
            xmlAdapter.load(fileName, fileType);

            return;
        }

        string file = fileName + ".json";

        Memento memento = new Memento();

        // 读取备忘录JSON文件
        string json = System.IO.File.ReadAllText(file);
        JsonUtility.FromJsonOverwrite(json, memento);

        // 读取游戏数据
        memento.loadGameFromMemento();
    }

    public void delete(string fileName, string fileType)
    {
        // 存档不存在
        if (!fileNameList.Contains(fileName))
        {
            Debug.Log("存档不存在");
            return;
        }

        // 删除存档名
        fileNameList.Remove(fileName);

        // 只支持JSON和XML格式
        if (fileType != "json" && fileType != "xml")
        {
            Debug.Log("文件类型不支持");
            return;
        }
        else if (fileName == "xml")
        {
            // 使用XML适配器对象
            xmlAdapter = new XMLAdapter();
            xmlAdapter.delete(fileName, fileType);

            return;
        }

        string file = fileName + ".json";
        System.IO.File.Delete(file);
    }
}
