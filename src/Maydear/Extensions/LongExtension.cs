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
using System.Collections.Generic;

namespace System
{
    /// <summary>
    /// int64扩展
    /// </summary>
    public static class LongExtension
    {
        /// <summary>
        /// 提取该值中存在2的N次方值
        /// </summary>
        /// <param name="total">待提取的值</param>
        /// <returns></returns>
        public static IEnumerable<long> ExtractTwoPow(this long total)
        {
            int position = 0;
            long flag = 0;
            while (total > flag)
            {
                flag = 0x01 << position++;
                if ((total & flag) > 0)
                {
                    yield return flag;
                }
            }
        }
        /// <summary>
        /// 位对比
        /// </summary>
        /// <param name="total">待提取的值</param>
        /// <param name="flag">匹配的位</param>
        /// <returns></returns>
        public static bool BitContrast(this long total, long flag)
        {
            return (total & flag) > 0;
        }

    }
}
