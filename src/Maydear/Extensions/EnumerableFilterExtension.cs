/*****************************************************************************************
* Copyright 2014-2019 The Maydear Authors
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*****************************************************************************************/
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
        /// 是否不为null且是空集合
        /// </summary>
        /// <param name="collection">集合</param>
        /// <returns></returns>
        public static bool IsNotNullAndEmpty<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
            {
                return false;
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
    }
}
