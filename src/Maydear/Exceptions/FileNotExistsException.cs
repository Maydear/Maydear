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
    /// (3011)文件不存在引发异常
    /// </summary>
    [Serializable]
    public class FileNotExistsException : StatusCodeException
    {
        /// <summary>
        /// 文件不存在时的公共错误码。
        /// </summary>
        private const int FILE_NOT_EXISTS_STATUS_CODE = 3011;

        public FileNotExistsException() 
            : base(FILE_NOT_EXISTS_STATUS_CODE, $"指定的文件不存在。")
        { }

        /// <summary>
        /// (3011)文件不存在引发异常。
        /// </summary>
        /// <param name="filePath"></param>
        public FileNotExistsException(string filePath)
            : base(FILE_NOT_EXISTS_STATUS_CODE, $"未能找到文件“{filePath}”。") { }

        /// <summary>
        /// (3011)文件不存在引发异常
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="innerException"></param>
        public FileNotExistsException(string filePath, Exception innerException) 
            : base(FILE_NOT_EXISTS_STATUS_CODE, $"未能找到文件“{filePath}”。", innerException)
        { }

        /// <summary>
        /// (3011)文件不存在引发异常
        /// </summary>
        /// <param name="innerException"></param>
        public FileNotExistsException(Exception innerException)
            : base(FILE_NOT_EXISTS_STATUS_CODE, "指定的文件不存在。", innerException) { }

        /// <summary>
        /// 用序列化数据初始化<see cref="KeySizeException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// 在反序列化过程中调用该构造函数来重建通过流传输的异常对象.
        /// </remarks>
        /// <param name="info">保存序列化对象<see cref="System.Runtime.Serialization.SerializationInfo"/>数据的对象。</param>
        /// <param name="context">有关源或目标的上下文信息。</param>
        protected FileNotExistsException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
