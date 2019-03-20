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
using System.ComponentModel;
using System.Linq;

/*****************************************************************************************
 * FileName:EnumExtension.cs
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
    /// 【枚举扩展】类
    /// </summary>
    public static class EnumExtension
    {
        /// <summary>
        /// 获取枚举对象描述信息
        /// </summary>
        /// <param name="enumObject">枚举对象</param>
        /// <returns>返回描述(Description)</returns>
        public static string GetDescription(this System.Enum enumObject)
        {
            var type = enumObject.GetType();

            var name = System.Enum.GetNames(type)
                .Where(f => f.Equals(enumObject.ToString(), StringComparison.CurrentCultureIgnoreCase))
                .Select(d => d)
                .FirstOrDefault();

            if (name == null) return string.Empty;

            var field = type.GetField(name);
            var customAttribute = field.GetCustomAttributes(typeof (DescriptionAttribute), false);
            return customAttribute.Length > 0 ? ((DescriptionAttribute) customAttribute[0]).Description : name;
        }

        /// <summary>
        /// 获取枚举对象对应整形值
        /// </summary>
        /// <param name="enumObject">枚举对象</param>
        /// <returns>返回整形值</returns>
        public static int GetValue(this System.Enum enumObject)
        {
            return (int)System.Enum.Parse(enumObject.GetType(), enumObject.ToString(), true);
        }
    }
}
