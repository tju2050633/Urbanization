using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterChain {
    private List<IResourceFilter> filters = new List<IResourceFilter>();

    public void addFilter(IResourceFilter filter) {
        filters.Add(filter);
    }

    public bool isEnough(Zone zone) {
        foreach (IResourceFilter filter in filters) {
            if (!filter.isEnough(zone)) {
                return false;
            }
        }
        return true;
    }
}