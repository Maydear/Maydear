using System.Collections.Generic;

namespace Maydear.Extensions
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
