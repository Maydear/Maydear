using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear
{
    /// <summary>
    /// 事件订阅提供者接口
    /// </summary>
    public interface IEventObserverProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<IEventObserver> GetEventObservers();
    }
}
