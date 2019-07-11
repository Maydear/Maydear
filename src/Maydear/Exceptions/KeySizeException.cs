/*****************************************************************************************
* Copyright 2014-2019 The Maydear Authors
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*****************************************************************************************/
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Maydear.Exceptions
{
    /// <summary>
    /// 加密的密钥长度不足时引发异常
    /// </summary>
    [Serializable]
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
        /// 加密的密钥长度不足时引发异常。
        /// </summary>
        /// <param name="keySize">密钥长度</param>
        public KeySizeException(int keySize)
            : base($"密钥长度不足，请使用{keySize}位的密钥。") { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="innerException"></param>
        public KeySizeException(Exception innerException)
            : base("加密的key长度不足引发异常。", innerException) { }


        /// <summary>
        /// 用序列化数据初始化<see cref="KeySizeException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// 在反序列化过程中调用该构造函数来重建通过流传输的异常对象.
        /// </remarks>
        /// <param name="info">保存序列化对象<see cref="System.Runtime.Serialization.SerializationInfo"/>数据的对象。</param>
        /// <param name="context">有关源或目标的上下文信息。</param>
        protected KeySizeException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
