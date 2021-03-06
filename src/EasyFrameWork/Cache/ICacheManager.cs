﻿/* http://www.zkea.net/ 
 * Copyright 2018 ZKEASOFT 
 * http://www.zkea.net/licenses */

using System;

namespace Easy.Cache
{
    public interface ICacheManager<T>
    {
        T GetOrAdd(string key, string region, Func<string, string, T> valueFactory);
        T GetOrAdd(string key, Func<string, T> valueFactory);
        T GetOrAdd(string key, string region, T value);
        T GetOrAdd(string key, T value);
        void Remove(string key);
        void ClearRegion(string region);
        void Clear();
    }
}
