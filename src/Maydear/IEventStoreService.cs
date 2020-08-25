using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear
{
    /// <summary>
    /// 事件朔源存储服务
    /// </summary>
    public interface IEventStoreService
    {
        /// <summary>
        /// 事件存储
        /// </summary>
        /// <param name="abstractEvent">事件</param>
        /// <param name="exception">异常记录</param>
        void Save(AbstractEvent abstractEvent, Exception exception);

        /// <summary>
        /// 事件重播
        /// </summary>
        void Replay();
    }
}
