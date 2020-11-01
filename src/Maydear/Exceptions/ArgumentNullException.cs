using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear.Exceptions
{
    /// <summary>
    /// (3001)将空引用传递给不接受为有效参数的方法时，将引发此异常。 使用场景等同<see cref="System.ArgumentNullException"/>
    /// </summary>
    [Serializable]
    public class ArgumentNullException : StatusCodeException
    {
        /// <summary>
        /// (3001)提供给方法的参数之一无效时引发的公共错误码。
        /// </summary>
        private const int ARGUMENT_NULL_STATUS_CODE = 3001;

        /// <summary>
        /// 构造(3001)将空引用传递给不接受为有效参数的异常
        /// </summary>
        /// <param name="message">异常信息</param>
        public ArgumentNullException(string message)
            : base(ARGUMENT_NULL_STATUS_CODE, message)
        {
        }

        /// <summary>
        /// 构造(3001)将空引用传递给不接受为有效参数的异常
        /// </summary>
        /// <param name="message">异常信息</param>
        /// <param name="innerException">异常</param>
        public ArgumentNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// 构造(3001)将空引用传递给不接受为有效参数的异常
        /// </summary>
        public ArgumentNullException()
            : base(ARGUMENT_NULL_STATUS_CODE, $"将空引用传递给不接受为有效参数。") { }

        /// <summary>
        /// 构造(3001)将空引用传递给不接受为有效参数的异常
        /// </summary>
        /// <param name="serializationInfo">保存序列化对象<see cref="System.Runtime.Serialization.SerializationInfo"/>数据的对象。</param>
        /// <param name="streamingContext">有关源或目标的上下文信息。</param>
        protected ArgumentNullException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) : base(serializationInfo, streamingContext) { }
    }
}
