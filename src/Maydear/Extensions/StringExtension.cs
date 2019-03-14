/*****************************************************************************************
* Copyright 2014-2017 The Maydear Authors
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
 * FileName:StringExtension.cs
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
    /// 字符串扩展
    /// </summary>
    public static class StringExtension
    {

        #region 字符串转换其他可空基础类型

        /// <summary>
        /// 字符串转整型
        /// </summary>
        /// <param name="strSource">数字字符串</param>
        /// <returns>转换成功则为实际数字，转换失败则返回null</returns>
        public static int? ToInt(this string strSource)
        {
            if (int.TryParse(strSource, out int result))
                return result;
            else
                return null;
        }

        /// <summary>
        /// 字符串转长整型
        /// </summary>
        /// <param name="strSource">数字字符串</param>
        /// <returns>转换成功则为实际数字，转换失败则返回null</returns>
        public static long? ToLong(this string strSource)
        {
            if (long.TryParse(strSource, out long result))
                return result;
            else
                return null;
        }

        /// <summary>
        /// 字符串转双精度浮点型
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns>转换成功则为实际数字，转换失败则返回null</returns>
        public static double? ToDouble(this string strSource)
        {
            if (double.TryParse(strSource, out double result))
                return result;
            else
                return null;
        }

        /// <summary>
        /// 字符串转高进度数字类型
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns>转换成功则为实际数字，转换失败则返回null</returns>
        public static decimal? ToDecimal(this string strSource)
        {
            if (decimal.TryParse(strSource, out decimal result))
                return result;
            else
                return null;
        }

        /// <summary>
        /// 字符串转布尔类型
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns>转换成功则为实际bool，转换失败则返回null</returns>
        public static bool? ToBoolean(this string strSource)
        {
            if (bool.TryParse(strSource, out bool result))
                return result;
            else
                return null;
        }

        /// <summary>
        /// 字符串转单精度浮点
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns>转换成功则为实际数字，转换失败则返回null</returns>
        public static float? ToFloat(this string strSource)
        {
            if (float.TryParse(strSource, out float result))
                return result;
            else
                return null;
        }

        /// <summary>
        /// 字符串转单精度浮点
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns>转换成功则为实际数字，转换失败则返回null</returns>
        public static DateTime? ToDateTime(this string strSource)
        {
            if (DateTime.TryParse(strSource, out DateTime result))
                return result;
            else
                return null;
        }

        #endregion

        #region 字符串转换其他基础类型

        /// <summary>
        /// 字符串转整型
        /// </summary>
        /// <param name="strSource">整型数字字符串</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>转换成功则为实际数字，转换失败则为默认值default(int)</returns>
        public static int ToIntOrDefault(this string strSource, int defaultValue = default(int))
        {
            if (Int32.TryParse(strSource, out int result))
                return result;
            else
                return defaultValue;
        }

        /// <summary>
        /// 字符串转长整型
        /// </summary>
        /// <param name="strSource">长整型数字字符串</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>转换成功则为实际数字，转换失败则为默认值</returns>
        public static long ToLongOrDefault(this string strSource, long defaultValue = default(long))
        {
            if (long.TryParse(strSource, out long result))
                return result;
            else
                return defaultValue;
        }

        /// <summary>
        /// 字符串转双精度浮点型
        /// </summary>
        /// <param name="strSource">双精度浮点型数字字符串</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>转换成功则为实际数字，转换失败则为默认值</returns>
        public static double ToDoubleOrDefault(this string strSource, double defaultValue = default(double))
        {
            if (double.TryParse(strSource, out double result))
                return result;
            else
                return defaultValue;
        }

        /// <summary>
        /// 字符串转高进度数字类型
        /// </summary>
        /// <param name="strSource">高进度数字类型字符串</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>转换成功则为实际数字，转换失败则为默认值</returns>
        public static decimal ToDecimalOrDefault(this string strSource, decimal defaultValue = default(decimal))
        {
            if (decimal.TryParse(strSource, out decimal result))
                return result;
            else
                return defaultValue;
        }

        /// <summary>
        /// 字符串转布尔类型
        /// </summary>
        /// <param name="strSource">布尔类型(true/false)字符串</param>
        /// <param name="defaultValue">转换失败时，返回的值</param>
        /// <returns>转换成功则为实际数字，转换失败则为默认值</returns>
        public static bool ToBooleanOrDefault(this string strSource, bool defaultValue = default(bool))
        {
            if (bool.TryParse(strSource, out bool result))
                return result;
            else
                return defaultValue;
        }

        /// <summary>
        /// 字符串转单精度浮点
        /// </summary>
        /// <param name="strSource">单精度浮点数字字符串</param>
        /// <param name="defaultValue">转换失败时，返回的值</param>
        /// <returns>转换成功则为实际数字，转换失败则为默认值</returns>
        public static float ToFloatOrDefault(this string strSource, float defaultValue = default(float))
        {
            if (float.TryParse(strSource, out float result))
                return result;
            else
                return defaultValue;
        }

        /// <summary>
        /// 带默认返回的日期类型转换
        /// </summary>
        /// <param name="strDateTime">日期字符串</param>
        /// <param name="defaultDate">如果转换失败，返回的日期值</param>
        /// <returns>返回一一个月第一天日期</returns>
        public static DateTime ToDateTimeOrDefault(this string strDateTime, DateTime defaultDate = default(DateTime))
        {
            if (DateTime.TryParse(strDateTime, out DateTime dtTime))
            {
                return dtTime;
            }
            else
            {
                return defaultDate;
            }
        }

        /// <summary>
        /// 将字符串转换为二进制字节（UTF8编码）
        /// </summary>
        /// <param name="input">待转换的数据源</param>
        /// <returns>返回一个字节数组</returns>
        public static byte[] ToBytes(this string input)
        {
            return ToBytes(input, Encoding.UTF8);
        }

        /// <summary>
        /// 将字符串转换为二进制字节
        /// </summary>
        /// <param name="input">待转换的数据源</param>
        /// <param name="encoding">编码类型</param>
        /// <returns>返回一个字节数组</returns>
        public static byte[] ToBytes(this string input, Encoding encoding)
        {
            return encoding.GetBytes(input);
        }
        #endregion
    }
}
