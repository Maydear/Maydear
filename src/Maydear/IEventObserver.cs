using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear
{
    /// <summary>
    /// 事件订阅者
    /// </summary>
    public interface IEventObserver
    {
        /// <summary>
        /// 接收事件
        /// </summary>
        /// <param name="eventEntity"></param>
        void Receive(AbstractEvent eventEntity);

        /// <summary>
        /// 是否支持的事件
        /// </summary>
        /// <param name="eventType">事件类型</param>
        /// <returns></returns>
        bool Support(Type eventType);

    }
}
