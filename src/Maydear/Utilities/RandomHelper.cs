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
    /// 随机数助手类
    /// </summary>
    public static class RandomHelper
    {
        /// <summary>
        /// 随机对象
        /// </summary>
        private static readonly Random random = new Random(DateTimeOffset.Now.Millisecond);

        /// <summary>
        /// 随机获取一个布尔值
        /// </summary>
        /// <returns></returns>
        public static bool NextBoolean()
        {
            return random.Next(0, 1) > 0;
        }

        /// <summary>
        /// 随机获取一个二进制数组
        /// </summary>
        /// <param name="count">数组长度</param>
        /// <returns></returns>
        public static byte[] NextBytes(int count)
        {
            byte[] result = new byte[count];
            random.NextBytes(result);

            return result;
        }

        /// <summary>
        /// 随机获取一个整型数值
        /// </summary>
        /// <param name="maxValue">最大值</param>
        /// <returns>返回最大值内的整形数值</returns>
        public static int Next(int maxValue)
        {
            return random.Next(maxValue);
        }

        /// <summary>
        /// 随机获取一个整型数值
        /// </summary>
        /// <param name="minValue">最小值</param>
        /// <param name="maxValue">最大值</param>
        /// <returns>返回区间内的整形数值</returns>
        public static int Next(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }

        /// <summary>
        /// 随机获取一个整型数值
        /// </summary>
        /// <returns>返回[-2147483648,2147483647]内的整形数值</returns>
        public static int Next()
        {
            return random.Next(int.MinValue,int.MaxValue);
        }

        /// <summary>
        /// 随机获取[0,2147483647]一个整型数值
        /// </summary>
        /// <returns>返回[0,2147483647]内的整形数值</returns>
        public static int NextInt()
        {
            return random.Next(0, int.MaxValue);
        }

        /// <summary>
        /// 随机获取一个长整型数值
        /// </summary>
        /// <returns>返回长整形数值</returns>
        public static long NextLong()
        {
            var buffer = new byte[sizeof(Int64)];
            random.NextBytes(buffer);
            return BitConverter.ToInt64(buffer, 0);
        }

        /// <summary>
        /// 随机获取一个单精度浮点数值
        /// </summary>
        /// <returns>返回单精度浮点数值</returns>
        public static float NextFloat()
        {
            var buffer = new byte[sizeof(float)];
            random.NextBytes(buffer);
            return BitConverter.ToSingle(buffer, 0);
        }

        /// <summary>
        /// 随机获取一个双精度浮点数值
        /// </summary>
        /// <returns>返回双精度浮点数值</returns>
        public static double NextDouble()
        {
            var buffer = new byte[sizeof(double)];
            random.NextBytes(buffer);
            return BitConverter.ToDouble(buffer, 0);
        }

        /// <summary>
        /// 随机获取集合中的一个对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">待随机抽取的对象</param>
        /// <returns></returns>
        public static T Next<T>(IList<T> list)
        {
            var index = Next(0, list.Count);
            return list[index];
        }
    }
}
