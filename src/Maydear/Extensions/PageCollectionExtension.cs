using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maydear
{
    /// <summary>
    /// 分页实体扩展
    /// </summary>
    public static class PageCollectionExtension
    {
        /// <summary>
        /// 转换分页实体
        /// </summary>
        /// <typeparam name="TSource">原类型</typeparam>
        /// <typeparam name="TTarget">目标类型</typeparam>
        /// <param name="sourcePageCollection">源分页实体</param>
        /// <param name="convert">转换的方法</param>
        /// <returns></returns>
        public static IPageCollection<TTarget> Convert<TSource, TTarget>(this IPageCollection<TSource> sourcePageCollection, Func<TSource, TTarget> convert)
        {
            return new PageCollection<TTarget>(sourcePageCollection.Data.Select(a => convert(a)), sourcePageCollection.RecordCount, sourcePageCollection.PageIndex, sourcePageCollection.PageSize);
        }
    }
}
