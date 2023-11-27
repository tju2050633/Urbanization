using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 工厂模式：资源工厂
public class ResourceFactory
{
    public Resource getResource(string resourceType)
    {
        return CacheFacade.getInstance().cloneResource(resourceType);
    }
}