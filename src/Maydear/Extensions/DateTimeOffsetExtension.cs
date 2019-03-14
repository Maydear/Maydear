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
using System;
using System.Globalization;
/*****************************************************************************************
 * FileName:DateTimeOffsetExtension.cs
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
    /// 【DateTimeOffset】扩展类
    /// </summary>
    public static class DateTimeOffsetExtension
    {
        /// <summary>
        /// 可空日期类型转指定格式字符串
        /// </summary>
        /// <param name="dteSource">可空日期对象</param>
        /// <param name="format">指定格式</param>
        /// <returns>转换成功则为指定格式字符串日期，否则返回空字符串</returns>
        public static string ToStringFormat(this DateTimeOffset? dteSource, string format = "yyyy-MM-dd HH:mm:ss")
        {
            return dteSource.HasValue ? dteSource.Value.ToString(format) : string.Empty;
        }

        /// <summary>
        /// 获取指定日期在一年中的周数
        /// </summary>
        /// <param name="dteSource"></param>
        /// <returns>返回一年中指定日期的周数</returns>
        public static int GetWeekOfYear(this DateTimeOffset dteSource)
        {
            GregorianCalendar gc = new GregorianCalendar();
            return gc.GetWeekOfYear(dteSource.DateTime, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        }
        
        /// <summary>
        /// 获取指定日期在一年中的周数
        /// </summary>
        /// <param name="dteSource">可空日期对象</param>
        /// <returns>返回一年中指定日期的周数</returns>
        public static int GetWeekOfYear(this DateTimeOffset? dteSource)
        {
            if (!dteSource.HasValue)
                return 0;
            GregorianCalendar gc = new GregorianCalendar();
            return gc.GetWeekOfYear(dteSource.Value.DateTime, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        }

        /// <summary>
        /// 时间日期对象转默认格式时间字符串
        /// </summary>
        /// <param name="dteSource">时间类型对象</param>
        /// <param name="format">格式字符串</param>
        /// <returns>返回指定时间格式字符串(如：2015-02-10 12:50:28)</returns>
        public static string ToStringOrDefault(this DateTimeOffset dteSource, string format = null)
        {
            return dteSource.ToString(string.IsNullOrWhiteSpace(format) ? "yyyy-MM-dd HH:mm:ss" : format);
        }

        /// <summary>
        /// 时间日期对象转默认格式时间字符串
        /// </summary>
        /// <param name="dteSource">时间类型对象</param>
        /// <param name="format">格式字符串</param>
        /// <returns>返回指定时间格式字符串(如：2015-02-10 12:50:28)</returns>
        public static string ToStringOrDefault(this DateTimeOffset? dteSource, string format = null)
        {
            if (!dteSource.HasValue)
            {
                return null;
            }

            return dteSource.Value.ToString(string.IsNullOrWhiteSpace(format) ? "yyyy-MM-dd HH:mm:ss" : format);
        }

        /// <summary>
        /// 时间日期对象转默认格式格式日期字符串(如：2015-02-10)
        /// </summary>
        /// <param name="dteSource">时间类型对象</param>
        /// <param name="format">格式字符串</param>
        /// <returns>返回指定日期格式字符串(如：2015-02-10)</returns>
        public static string ToDateStringOrDefault(this DateTimeOffset dteSource, string format = null)
        {
            return dteSource.ToString(string.IsNullOrWhiteSpace(format) ? "yyyy-MM-dd" : format);
        }

        /// <summary>
        /// 时间日期对象转默认格式格式日期字符串(如：2015-02-10)
        /// </summary>
        /// <param name="dteSource">时间类型对象</param>
        /// <param name="format">格式字符串</param>
        /// <returns>返回指定日期格式字符串(如：2015-02-10)</returns>
        public static string ToDateStringOrDefault(this DateTimeOffset? dteSource, string format = null)
        {
            if (!dteSource.HasValue)
            {
                return null;
            }

            return dteSource.Value.ToString(string.IsNullOrWhiteSpace(format) ? "yyyy-MM-dd" : format);
        }
    }
}
