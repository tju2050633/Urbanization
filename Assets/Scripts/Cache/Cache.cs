using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 缓存接口，声明区域、地形、地貌、资源缓存类的获取克隆对象的方法。
// 原型模式：提前缓存创建的类作为原型，需要时克隆原型。
public interface ICache
{
    object getClone(string type);
}