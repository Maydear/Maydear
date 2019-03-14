using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    /// <summary>
    /// IEnumerable扩展
    /// </summary>
    public static class EnumerableFilterExtension
    {
        /// <summary>
        /// 是否null或空集合
        /// </summary>
        /// <param name="collection">集合</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
            {
                return true;
            }

            return !collection.Any();
        }

        /// <summary>
        /// 不为null
        /// </summary>
        /// <param name="collection">集合</param>
        /// <returns>如果不是null对象或不是空集合则返回true，反之则为false</returns>
        public static bool IsNotNull<T>(this IEnumerable<T> collection)
        {
            if (collection != null)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 不为空集合
        /// </summary>
        /// <param name="collection">集合</param>
        /// <returns>如果不是null对象或不是空集合则返回true，反之则为false</returns>
        public static bool IsNotEmpty<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
            {
                return false;
            }

            return collection.Any();
        }

        /// <summary>
        /// 不为null或不是空集合
        /// </summary>
        /// <param name="collection">集合</param>
        /// <returns>如果不是null对象或不是空集合则返回true，反之则为false</returns>
        public static bool IsNotNullOrNotEmpty<T>(this IEnumerable<T> collection)
        {
            return !collection.IsNullOrEmpty();
        }
    }
}
