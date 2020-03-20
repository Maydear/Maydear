using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear.Exceptions
{
    /// <summary>
    /// (3000) 提供给方法的参数之一无效时引发的异常。使用场景等同<see cref="System.ArgumentException"/>
    /// </summary>
    [Serializable]
    public class ArgumentException : StatusCodeException
    {
        /// <summary>
        /// (3000)提供给方法的参数之一无效时引发的公共错误码。
        /// </summary>
        private const int ARGUMENT_STATUS_CODE = 3000;

        /// <summary>
        /// 参数名
        /// </summary>
        public virtual string ParamName { get; private set; }

        /// <summary>
        /// (3000) 提供给方法的参数之一无效时引发的异常。使用场景等同<see cref="System.ArgumentException"/>
        /// </summary>
        /// <param name="message">参数名</param>
        public ArgumentException(string message)
            : base(ARGUMENT_STATUS_CODE, $"参数“{message}”异常。")
        {
            ParamName = message;
        }

        /// <summary>
        /// (3000) 提供给方法的参数之一无效时引发的异常。使用场景等同<see cref="System.ArgumentException"/>
        /// </summary>
        /// <param name="message">参数名</param>
        /// <param name="innerException">异常</param>
        public ArgumentException(string message, Exception innerException)
            : base(ARGUMENT_STATUS_CODE, $"参数“{message}”异常。", innerException)
        {
            ParamName = message;
        }

        /// <summary>
        /// (3000) 提供给方法的参数之一无效时引发的异常。使用场景等同<see cref="System.ArgumentException"/>
        /// </summary>
        public ArgumentException()
            : base(ARGUMENT_STATUS_CODE, $"参数异常。")
        { }

        /// <summary>
        /// 用序列化数据初始化<see cref="StatusCodeException"/>类的新实例。
        /// <para>**不建议直接new使用,给那些自愿被拖出去打死的懒人使用**</para>
        /// <para>**正确的使用方式应该是继承该类自定“StatusCode”后使用，每一个StatusCode对应一种异常类型**</para>
        /// </summary>
        /// <remarks>
        /// 在反序列化过程中调用该构造函数来重建通过流传输的异常对象.
        /// </remarks>
        /// <param name="info">保存序列化对象<see cref="System.Runtime.Serialization.SerializationInfo"/>数据的对象。</param>
        /// <param name="context">有关源或目标的上下文信息。</param>
        protected ArgumentException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
            : base(serializationInfo, streamingContext) { }
    }
}
