using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear.Exceptions
{

    /// <summary>
    /// 加密的密钥长度不足时引发异常
    /// </summary>
    public class KeySizeException : MaydearException
    {
        /// <summary>
        /// 加密的密钥长度不足时引发异常。
        /// </summary>
        public KeySizeException()
            : this("密钥长度不足，请使用更长的密钥。") { }

        /// <summary>
        /// 加密的密钥长度不足时引发异常。
        /// </summary>
        /// <param name="message"></param>
        public KeySizeException(string message)
            : base(message) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="innerException"></param>
        public KeySizeException(Exception innerException)
            : base("加密的key长度不足引发异常。", innerException) { }
    }
}
