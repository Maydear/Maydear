using System.Collections.Generic;

namespace Maydear.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class IntExtension
    {
        /// <summary>
        /// 提取该值中存在2的N次方值
        /// </summary>
        /// <param name="total">待提取的值</param>
        /// <returns></returns>
        public static IEnumerable<int> ExtractTwoPow(this int total)
        {
            int position = 0;
            int flag = 0;
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
        public static bool BitContrast(this int total, int flag)
        {
            return (total & flag) > 0;
        }
    }
}
