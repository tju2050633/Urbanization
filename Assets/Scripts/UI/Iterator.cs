using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 迭代器模式：迭代器接口，需要实现hasNext()和next()方法
public interface Iterator
{
    public bool hasNext();
    public object next();
}