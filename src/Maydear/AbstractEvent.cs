using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear
{
    /// <summary>
    /// 抽象事件
    /// </summary>
    public abstract class AbstractEvent
    {
        /// <summary>
        /// 事件参数
        /// </summary>
        public object Args { get; set; }

        /// <summary>
        /// 事件ID
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; private set; }

        /// <summary>
        /// 构造事件
        /// </summary>
        /// <param name="args"></param>
        protected AbstractEvent(object args)
        {
            Args = args;
            Id = Guid.NewGuid();
            CreateTime = DateTime.Now;
        }
    }

    /// <summary>
    /// 泛型抽象事件
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractEvent<T> : AbstractEvent where T : class
    {
        /// <summary>
        /// 事件参数
        /// </summary>
        public new T Args { get; set; }

        /// <summary>
        /// 构造事件
        /// </summary>
        /// <param name="args"></param>
        protected AbstractEvent(T args) : base(args)
        {
        }
    }
}
