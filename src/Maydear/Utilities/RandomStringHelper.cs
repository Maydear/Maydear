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
using System.Text;

namespace Maydear.Utilities
{
    /// <summary>
    /// 随机字符串助手类
    /// </summary>
    public static class RandomStringHelper
    {
        /// <summary>
        /// 获取随机字母字符串
        /// </summary>
        /// <param name="count">字符串长度</param>
        /// <returns>返回指定长度的字母字符串</returns>
        public static string NextLettersString(int length)
        {
            if (length <= 0)
            {
                return string.Empty;
            }

            const int asciiStart = (int)'a';
            const int asciiEnd = (int)'z';
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(Convert.ToChar(RandomHelper.Next(asciiStart, asciiEnd)));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取随机可见Ascii字符串
        /// </summary>
        /// <param name="count">待返回字符串长度</param>
        /// <returns>返回指定长度的Ascii字符串</returns>
        public static string NextAsciiString(int length)
        {
            if (length <= 0)
            {
                return string.Empty;
            }

            const int asciiStart = 33;
            const int asciiEnd = 126;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                var index = RandomHelper.Next(asciiStart, asciiEnd);
                sb.Append(Convert.ToChar(index));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取随机数字字符串
        /// </summary>
        /// <param name="count">字符串长度</param>
        /// <returns>返回指定长度的数字字符串</returns>
        public static string NextNumberString(int length)
        {
            if (length <= 0)
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(RandomHelper.Next(0, 9));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取指定来源的随机字符串
        /// </summary>
        /// <param name="count">字符串长度</param>
        /// <param name="source">来源字符数据</param>
        /// <returns>返回指定长度的字符串</returns>
        public static string NextString(int length, string source)
        {
            if (length <= 0)
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(RandomHelper.Next<char>(source.ToCharArray()));
            }
            return sb.ToString();
        }
    }
}
