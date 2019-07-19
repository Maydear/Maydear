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
using System.Security.Cryptography;
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
        private static readonly RandomNumberGenerator randomGenerator = RandomNumberGenerator.Create();

        /// <summary>
        /// 随机获取一个布尔值
        /// </summary>
        /// <returns></returns>
        public static bool NextBoolean()
        {
            Random random = new Random(Seed());
            return random.Next(0, 1) > 0;
        }

        private static int Seed()
        {
            byte[] buffer = new byte[sizeof(int)];
            randomGenerator.GetBytes(buffer);
            return BitConverter.ToInt32(buffer, 0);
        }

        /// <summary>
        /// 随机获取一个二进制数组
        /// </summary>
        /// <param name="length">数组长度</param>
        /// <returns></returns>
        public static byte[] NextBytes(int length)
        {
            byte[] buffer = new byte[length];
            randomGenerator.GetBytes(buffer);
            return buffer;
        }

        /// <summary>
        /// 随机获取一个整型数值
        /// </summary>
        /// <param name="maxValue">最大值</param>
        /// <returns>返回最大值内的整形数值</returns>
        public static int Next(int maxValue)
        {
            Random random = new Random(Seed());
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
            Random random = new Random(Seed());
            return random.Next(minValue, maxValue);
        }

        /// <summary>
        /// 随机获取一个整型数值
        /// </summary>
        /// <returns>返回[-2147483648,2147483647]内的整形数值</returns>
        public static int Next()
        {
            Random random = new Random(Seed());
            return random.Next();
        }

        /// <summary>
        /// 随机获取[0,2147483647]一个整型数值
        /// </summary>
        /// <returns>返回[0,2147483647]内的整形数值</returns>
        public static uint NextUInt()
        {
            byte[] buffer = new byte[sizeof(uint)];
            randomGenerator.GetBytes(buffer);
            return BitConverter.ToUInt32(buffer, 0);
        }

        /// <summary>
        /// 随机获取一个长整型数值
        /// </summary>
        /// <returns>返回长整形数值</returns>
        public static long NextLong()
        {
            byte[] buffer = new byte[sizeof(long)];
            randomGenerator.GetBytes(buffer);
            return BitConverter.ToInt64(buffer, 0);
        }

        /// <summary>
        /// 随机获取一个单精度浮点数值
        /// </summary>
        /// <returns>返回单精度浮点数值</returns>
        public static float NextFloat()
        {
            byte[] buffer = new byte[sizeof(float)];
            randomGenerator.GetBytes(buffer);
            return BitConverter.ToSingle(buffer, 0);
        }

        /// <summary>
        /// 随机获取一个双精度浮点数值
        /// </summary>
        /// <returns>返回双精度浮点数值</returns>
        public static double NextDouble()
        {
            byte[] buffer = new byte[sizeof(double)];
            randomGenerator.GetBytes(buffer);
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
            Random random = new Random(Seed());
            int index = random.Next(0, list.Count);
            return list[index];
        }
    }
}
