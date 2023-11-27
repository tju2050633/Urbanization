using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 工厂模式：地貌工厂
public class FeatureFactory
{
    public Feature getFeature(string featureType)
    {
        return CacheFacade.getInstance().cloneFeature(featureType);
    }
}