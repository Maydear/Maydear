using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Maydear.Exceptions
{
    /// <summary>
    /// 带自定义的状态码
    /// </summary>
    [Serializable]
    public class StatusCodeException : MaydearException
    {
        /// <summary>
        /// 错误状态码
        /// </summary>
        public int StatusCode { get; private set; }

        /// <summary>
        /// 初始化<see cref="StatusCodeException"/>类的新实例。
        /// </summary>
        /// <param name="statusCode">解释异常原因的错误状态码.</param>
        public StatusCodeException(int statusCode)
            : base()
        {
            StatusCode = statusCode;
        }

        /// <summary>
        /// 初始化<see cref="StatusCodeException"/>类的新实例。
        /// </summary>
        /// <param name="statusCode">解释异常原因的错误状态码.</param>
        /// <param name="message">解释异常原因的错误信息。</param>
        /// <remarks>
        /// 本构造函数使用<para>带有错误的错误</para>信息.
        /// </remarks>
        public StatusCodeException(int statusCode, string message)
            : base(message)
        {
            StatusCode = statusCode;
        }


        /// <summary>
        /// 使用指定<see cref="System.Exception"/>的异常对象初始化<see cref="StatusCodeException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// 本构造函数使用框架预设<para>错误</para>信息.并且以<see cref="System.Exception"/>作为参数。
        /// </remarks>
        /// <param name="statusCode">解释异常原因的错误状态码。</param>
        /// <param name="innerException">
        /// 导致当前异常的异常，如果<see cref="System.Exception"/> 参数不为空引用，则在处理内部异常的 catch 块中引发当前异常。
        /// </param>
        public StatusCodeException(int statusCode, Exception innerException)
            : this(statusCode, innerException.Message, innerException) { }

        /// <summary>
        /// 使用指定错误消息和对作为此异常原因的内部异常的引用来初始化<see cref="StatusCodeException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// message 参数的内容应为人所理解。 此构造函数的调用方需要确保此字符串已针对当前系统区域性进行了本地化。作为
        /// 上一异常直接结果而引发的异常应在 InnerException 属性中包括对上一异常的引用。<see cref="System.Exception"/> 
        /// 属性返回的值与传递到构造函数中的值相同；或者，如果 <see cref="System.Exception"/>属性不向构造函数提供内部异常值，
        /// 则为空引用。
        /// </remarks>
        /// <param name="statusCode">解释异常原因的错误状态码。</param>
        /// <param name="message">解释异常原因的错误信息。</param>
        /// <param name="innerException">导致当前异常的异常。 如果innerException参数不为空引用，则在处理内部异常的 catch 块中引发当前异常。 </param>
        public StatusCodeException(int statusCode, string message, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
        }

        /// <summary>
        /// 用序列化数据初始化<see cref="StatusCodeException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// 在反序列化过程中调用该构造函数来重建通过流传输的异常对象.
        /// </remarks>
        /// <param name="info">保存序列化对象<see cref="System.Runtime.Serialization.SerializationInfo"/>数据的对象。</param>
        /// <param name="context">有关源或目标的上下文信息。</param>
        protected StatusCodeException(SerializationInfo info, StreamingContext context) 
            : base(info, context) { }

    }
}
