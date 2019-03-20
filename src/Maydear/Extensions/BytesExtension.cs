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
using System.Text;

/*****************************************************************************************
 * FileName:BytesExtension.cs
 * Author:Kelvin
 * CreateDate:2014/09/22 15:02:45
 * Description:
 *        
 *        <version>	|	<author>	|<time>			        |	<desc>
 *        1		    |	Kelvin		|2014-09-22 15:20:00	|	创建文件
 ****************************************************************************************/

namespace System
{
    /// <summary>
    /// 字节数组扩展类
    /// </summary>
    public static class BytesExtension
    {
        /// <summary>
        /// 将 8 位无符号整数的数组转换为其用 Base64 数字编码的等效字符串表示形式。
        /// </summary>
        /// <param name="inArray"> 8 位无符号整数数组。</param>
        /// <returns>返回 inArray 的字符串表示形式，以 Base64 表示。</returns>
        public static string ToBase64String(this byte[] inArray)
        {
            if (inArray == null || inArray.Length == 0)
                return string.Empty;
            return Convert.ToBase64String(inArray);

        }

        /// <summary>
        /// 将 8 位无符号整数的数组转换为其用 16进制数字编码的等效字符串表示形式.
        /// </summary>
        /// <param name="inArray"> 8 位无符号整数数组。</param>
        /// <returns>返回 inArray 的字符串表示形式，以 16进制数字编码 表示。</returns>
        public static string ToHexString(this byte[] inArray)
        {
            if (inArray == null || inArray.Length == 0)
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            foreach (var item in inArray)
            {
                sb.Append(string.Format("{0:x2}", item));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 将 8 位无符号整数的数组转换为其用 UTF8 字符编码的等效字符串表示形式.
        /// </summary>
        /// <param name="inArray">8 位无符号整数数组。</param>
        /// <returns>返回 inArray 的字符串表示形式，以 UTF8 字符编码表示。</returns>
        public static string ToTextString(this byte[] inArray)
        {
            return ToTextString(inArray, Encoding.UTF8);
        }

        /// <summary>
        /// 将 8 位无符号整数的数组转换为 encoding参数指定的  字符编码的等效字符串表示形式.
        /// </summary>
        /// <param name="inArray">由字符数据组成的字节数据</param>
        /// <param name="encoding">指定的字符编码</param>
        /// <returns>返回 inArray 的字符串表示形式，以 encoding参数指定的 字符编码表示。</returns>
        public static string ToTextString(this byte[] inArray, Encoding encoding)
        {
            return encoding.GetString(inArray);
        }
    }
}
