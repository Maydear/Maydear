using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear
{
    /// <summary>
    /// api包裹对象
    /// </summary>
    public interface IPackageObject<T>
    {
        /// <summary>
        /// 请求识别号
        /// </summary>
        Guid RequestId { get; set; }

        /// <summary>
        /// 现在的时间
        /// </summary>
        DateTimeOffset Now { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        int StatusCode { get; set; }

        /// <summary>
        /// 消息提示
        /// </summary>
        string Notification { get; set; }

        /// <summary>
        /// 数据内容
        /// </summary>
        T Body { get; set; }
    }
}
