using System;
using System.Collections.Generic;
using System.Text;

namespace Web.NetCore.Commons.MemoryCache
{

    /// <summary>
    /// 简单的缓存接口，只有查询和添加
    /// </summary>
    public interface ICaching
    {
        object Get(string cacheKey);

        void Set(string cacheKey, object cacheValue);
    }
}

