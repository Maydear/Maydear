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
using System.Text.RegularExpressions;

/*****************************************************************************************
 * FileName:StringFilterExtension.cs
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
    /// 字符过滤
    /// </summary>
    public static class StringFilterExtension
    {
        /// <summary>
        /// 字符串是否为NULL 、Empty 、全空格
        /// </summary>
        /// <param name="data">待验证的字符串</param>
        /// <returns>如果字符串为为NULL 、Empty 、全空格则返回teue，反之则为false</returns>
        public static bool IsNullOrWhiteSpace(this string data)
        {
            return string.IsNullOrWhiteSpace(data);
        }

        /// <summary>
        /// 字符串是否为NULL,Empty
        /// </summary>
        /// <param name="data">待验证的字符串</param>
        /// <returns>如果字符串为为NULL 、Empty，反之则为false.</returns>
        public static bool IsNullOrEmpty(this string data)
        {
            return string.IsNullOrEmpty(data);
        }


        /// <summary>
        /// 是否为Email
        /// </summary>
        /// <param name="data">待验证的字符串</param>
        /// <returns>返回一个bool类型，字符串满足标准Email格式则返回true,反之则为false</returns>
        public static bool IsEmail(this string data)
        {
            Regex re = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            return re.IsMatch(data);
        }

        /// <summary>
        /// 是否为中国手机号码
        /// </summary>
        /// <param name="data">待验证的字符串</param>
        /// <returns>返回一个bool类型，字符串满足标准中国手机号码格式则返回true,反之则为false</returns>
        public static bool IsChinaMobilePhone(this string data)
        {
            Regex re = new Regex(@"((^13[0-9])|(^14[0-8])|(^15([0-3]|[5-9]))|(^166)|(^17[0-9])|(^18[0-9])|(^19[8-9]))\d{8}$");

            return re.IsMatch(data);
        }

        /// <summary>
        /// 是否为Number
        /// </summary>
        /// <param name="data">待验证的字符串</param>
        /// <returns>返回一个bool类型，字符串由数字组成则返回true,反之则为false</returns>
        public static bool IsNumber(this string data)
        {
            Regex re = new Regex(@"^[0-9]*$");

            return re.IsMatch(data);
        }

        /// <summary>
        /// 验证由数字、26个英文字母或者下划线组成的字符串
        /// </summary>
        /// <param name="data">待验证的字符串</param>
        /// <returns>返回一个bool类型，字符串由数字、26个英文字母或者下划线组成则返回true,反之则为false</returns>
        public static bool IsVar(this string data)
        {
            Regex reg = new Regex(@"^\w+$");

            return reg.IsMatch(data);
        }

        /// <summary>
        /// 验证是否为URi
        /// </summary>
        /// <param name="data">待验证的字符串</param>
        /// <returns>返回一个bool类型，字符串由为一个URL链接则返回true,反之则为false</returns>
        public static bool IsUri(this string data)
        {
            Regex reg = new Regex(@"^[a-zA-z]+://(\w+(-\w+)*)(\.(\w+(-\w+)*))*(\?\s*)?$");
            return reg.IsMatch(data);
        }

        /// <summary>
        /// 验证是否为URL
        /// </summary>
        /// <param name="data">待验证的字符串</param>
        /// <returns>返回一个bool类型，字符串由为一个URL链接则返回true,反之则为false</returns>
        public static bool IsHttpUrl(this string data)
        {
            Regex reg = new Regex(@"^(http|https)://(\w+(-\w+)*)(\.(\w+(-\w+)*))*(\?\s*)?$");
            return reg.IsMatch(data);
        }

        /// <summary>
        /// 验证是否为中文
        /// </summary>
        /// <param name="data">待验证的字符串</param>
        /// <returns>返回一个bool类型，字符串由中文组成则返回true,反之则为false</returns>
        public static bool IsChinese(this string data)
        {
            Regex reg = new Regex(@"[\u4e00-\u9fa5]");
            return reg.IsMatch(data);
        }

        /// <summary>
        /// 是否安全字符串，例如包含"slect insert"等注入关键字
        /// </summary>
        /// <param name="data">待验证的字符串</param>
        /// <returns>返回一个bool类型，字符串包含SQL注入攻击字段则返回false,反之则为true</returns>
        public static bool IsSafety(this string data)
        {
            string text1 = data.Replace("%20", " ");
            text1 = Regex.Replace(text1, @"\s", " ");
            string text2 = "select |insert |delete from |count\\(|drop table|update |truncate |asc\\(|mid\\(|char\\(|xp_cmdshell|exec master|net localgroup administrators|:|net user|\"|\\'| or ";
            return !Regex.IsMatch(text1, text2, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 是否合法中国身份证号（18位）
        /// </summary>
        /// <param name="data">待验证的中国身份证号</param>
        /// <returns>返回一个bool类型，字符串不是合法身份证号则返回false,反之则为true</returns>
        public static bool IsChineseIdNumber18(this string data)
        {
            //不满18位
            if (data.Length != 18)
            {
                return false;
            }

            data = data.Replace('Ｘ', 'x').Replace('ｘ', 'x').ToLower();
            Regex regex = new Regex(@"^\d{17}(\d|x)$");
            Match match = regex.Match(data);
            if (!match.Success)
            {
                return false;
            }

            string[] aCity = new string[] { null, null, null, null, null, null, null, null, null, null, null, "北京", "天津", "河北", "山西", "内蒙古", null, null, null, null, null, "辽宁", "吉林", "黑龙江", null, null, null, null, null, null, null, "上海", "江苏", "浙江", "安微", "福建", "江西", "山东", null, null, null, "河南", "湖北", "湖南", "广东", "广西", "海南", null, null, null, "重庆", "四川", "贵州", "云南", "西藏", null, null, null, null, null, null, "陕西", "甘肃", "青海", "宁夏", "新疆", null, null, null, null, null, "台湾", null, null, null, null, null, null, null, null, null, "香港", "澳门", null, null, null, null, null, null, null, null, "国外" };

            if (aCity[int.Parse(data.Substring(0, 2))] == null)
            {
                return false;
            }

            if (!DateTime.TryParse($"{data.Substring(6, 4)}-{data.Substring(10, 2)}-{data.Substring(12, 2)}", out DateTime date))
            {
                return false;
            }

            int[] wi = new int[] { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2, 1 };
            char[] checkCode = new char[] { '1', '0', 'x', '9', '8', '7', '6', '5', '4', '3', '2' };

            int sum = 0;

            //只取前17位
            for (int i = 0; i < data.Length - 1; i++)
            {
                sum += int.Parse(data[i].ToString()) * wi[i];
            }

            int mod = sum % 11;

            if (!data[17].Equals(checkCode[mod]))
            {
                return false;
            }

            return true;
        }
    }
}
