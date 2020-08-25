using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear
{
    /// <summary>
    /// 事件管道
    /// </summary>
    public class EventBus
    {
        /// <summary>
        /// 事件朔源
        /// </summary>
        private readonly IEventStoreService eventStoreService;

        /// <summary>
        /// 事件供给者
        /// </summary>
        private readonly IEventObserverProvider eventObserverProvider;

        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="eventStoreService"></param>
        /// <param name="eventObserverProvider"></param>
        public EventBus(IEventStoreService eventStoreService, IEventObserverProvider eventObserverProvider)
        {
            this.eventStoreService = eventStoreService;
            this.eventObserverProvider = eventObserverProvider;
        }

        /// <summary>
        /// 发布事件
        /// </summary>
        /// <param name="eventEntity"></param>
        public void Publish(AbstractEvent eventEntity)
        {
            IList<IEventObserver> eventObservers = eventObserverProvider.GetEventObservers();

            foreach (IEventObserver eventObserver in eventObservers)
            {
                if (eventObserver.Support(eventEntity.GetType()))
                {
                    try
                    {
                        eventObserver.Receive(eventEntity);
                    }
                    catch(Exception ex)
                    {
                        eventStoreService.Save(eventEntity, ex);
                    }
                }
            }
        }
    }
}
