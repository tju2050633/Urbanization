using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 文件处理接口
public interface IFileHandler
{
    void save(string fileName, string fileType);
    void load(string fileName, string fileType);
    void delete(string fileName, string fileType);
}