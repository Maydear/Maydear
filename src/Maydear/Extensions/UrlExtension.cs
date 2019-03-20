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
using System.Text.RegularExpressions;
/*****************************************************************************************
 * FileName:UrlExtension.cs
 * Author:Kelvin
 * CreateDate:2014/09/22 15:02:45
 * Description:
 *        
 *        <version>	|	<author>	|<time>			        |	<desc>
 *        1		    |	Kelvin		|2014-09-22 15:20:00	|	创建文件
 ****************************************************************************************/

namespace Maydear.Extensions
{
    /// <summary>
    /// 字符串扩展
    /// </summary>
    public static class UrlExtension
    {
        #region url字符串提取

        /// <summary>
        /// 提取host信息
        /// </summary>
        /// <param name="url">http|https的url地址</param>
        /// <returns></returns>
        public static string ExtractHost(this string url)
        {
            try
            {
                Uri uri = new Uri(url);
                return $"{uri.Host}:{uri.Port}";
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 提取host信息
        /// </summary>
        /// <param name="url">http|https的url地址</param>
        /// <returns></returns>
        public static string ExtractHostName(this string url)
        {
            try
            {
                Uri uri = new Uri(url);
                return $"{uri.Host}";
            }
            catch
            {
                return string.Empty;
            }
        }


        /// <summary>
        /// 获取路径及参数
        /// </summary>
        /// <param name="url">http|https结构的url地址</param>
        /// <returns></returns>
        [Obsolete("StringExtension.ExtractPathAndQuery(string url)")]
        public static string ExtractRelativelyPath(this string url)
        {
            try
            {
                Uri uri = new Uri(url);
                return uri.PathAndQuery;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 获取路径及参数
        /// </summary>
        /// <param name="url">http|https结构的url地址</param>
        /// <returns></returns>
        public static string ExtractPathAndQuery(this string url)
        {
            try
            {
                Uri uri = new Uri(url);
                return uri.PathAndQuery;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 提取绝对路径
        /// </summary>
        /// <param name="url">http|https结构的url地址</param>
        /// <returns></returns>
        public static string ExtractAbsolutePath(this string url)
        {
            try
            {
                Uri uri = new Uri(url);
                return uri.AbsolutePath;
            }
            catch
            {
                return string.Empty;
            }
        }

        #endregion

        /// <summary>
        /// 分割QueryString参数及其值
        /// </summary>
        /// <param name="query">Url传递的参数</param>
        /// <returns></returns>
        public static IDictionary<string, string> ParseQueryString(this string query)
        {
            if (query.StartsWith("?"))
            {
                query = query.Substring(1);
            }

            if (string.IsNullOrEmpty(query))
            {
                return new Dictionary<string, string>();
            }

            string[] parts = query.Split(new[] { '&' });

            return parts.Select(
                part => part.Split(new[] { '=' })).ToDictionary(
                    pair => pair[0], pair => pair[1]
                );
        }

        /// <summary>
        /// Url编码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string UrlEncode(this string value)
        {
            return Uri.EscapeDataString(value);
        }

        /// <summary>
        /// Url解码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string UrlDecode(this string value)
        {
            return Uri.UnescapeDataString(value);
        }

    }
}
