using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    /// <summary>
    /// Guid类型扩展
    /// </summary>
    public static class GuidExtension
    {
        /// <summary>
        /// 验证GUID不是一个空的GUID（00000000-0000-0000-0000-000000000000）
        /// </summary>
        /// <param name="data">待验证的字符串</param>
        /// <returns>返回一个bool类型，字符串由数字、26个英文字母或者下划线组成则返回true,反之则为false</returns>
        public static bool IsNotEmpty(this Guid data)
        {
            return data != Guid.Empty;
        }
    }
}
