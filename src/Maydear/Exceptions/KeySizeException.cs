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
        /// 加密的密钥长度不足时引发异常。
        /// </summary>
        /// <param name="message"></param>
        public KeySizeException(int keySize)
            : base($"密钥长度不足，请使用{keySize}位的密钥。") { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="innerException"></param>
        public KeySizeException(Exception innerException)
            : base("加密的key长度不足引发异常。", innerException) { }
    }
}
