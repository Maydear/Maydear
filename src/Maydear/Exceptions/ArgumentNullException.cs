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
        /// 
        /// </summary>
        /// <param name="message"></param>
        public ArgumentNullException(string message) 
            : base(ARGUMENT_NULL_STATUS_CODE, message)
        {
        }

        public ArgumentNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ArgumentNullException()
        {
        }

        protected ArgumentNullException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}
