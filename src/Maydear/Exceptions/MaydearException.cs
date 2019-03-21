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
using System.Runtime.Serialization;
/*****************************************************************************************
 * FileName:MaydearException.cs
 * Author:Kelvin
 * CreateDate:2014/09/22 15:02:45
 * Description:
 *        
 *        <version>	|	<author>	|<time>			        |	<desc>
 *        1		    |	Kelvin		|2014-09-22 15:20:00	|	创建文件
 ****************************************************************************************/
namespace Maydear.Exceptions
{
    /// <summary>
    /// 当数据访问层发生非致命应用程序错误时引发的异常。
    /// </summary>
    /// <remarks>
    /// 为框架基础异常本框架所有的异常都继承于此。
    /// </remarks>
    [Serializable]
    public class MaydearException : Exception
    {
        /// <summary>
        /// 初始化<see cref="MaydearException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// 本构造函数使用框架预设<para>错误</para>信息.
        /// </remarks>
        public MaydearException()
            : base("Maydear.Common引发异常。") { }

        /// <summary>
        /// 使用指定<see cref="System.Exception"/>的异常对象初始化<see cref="MaydearException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// 本构造函数使用框架预设<para>错误</para>信息.并且以<see cref="System.Exception"/>作为参数。
        /// </remarks>
        /// <param name="innerException">
        /// 导致当前异常的异常，如果<see cref="System.Exception"/> 参数不为空引用，则在处理内部异常的 catch 块中引发当前异常。
        /// </param>
        public MaydearException(Exception innerException)
            : this("Maydear.Common引发异常。", innerException) { }

        /// <summary>
        /// 使用指定错误消息初始化<see cref="MaydearException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// message 参数的内容应为人所理解。 此构造函数的调用方需要确保此字符串已针对当前系统区域性进行了本地化。
        /// </remarks>
        /// <param name="message">
        /// 描述错误的消息。
        /// </param>
        public MaydearException(string message)
            : base(message) { }

        /// <summary>
        /// 使用指定错误消息和对作为此异常原因的内部异常的引用来初始化<see cref="MaydearException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// message 参数的内容应为人所理解。 此构造函数的调用方需要确保此字符串已针对当前系统区域性进行了本地化。作为
        /// 上一异常直接结果而引发的异常应在 InnerException 属性中包括对上一异常的引用。<see cref="System.Exception"/> 
        /// 属性返回的值与传递到构造函数中的值相同；或者，如果 <see cref="System.Exception"/>属性不向构造函数提供内部异常值，
        /// 则为空引用。
        /// </remarks>
        /// <param name="message">解释异常原因的错误信息。</param>
        /// <param name="innerException">导致当前异常的异常。 如果innerException参数不为空引用，则在处理内部异常的 catch 块中引发当前异常。 </param>
        public MaydearException(string message, Exception innerException)
            : base(message, innerException) { }

        /// <summary>
        /// 用序列化数据初始化<see cref="MaydearException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// 在反序列化过程中调用该构造函数来重建通过流传输的异常对象.
        /// </remarks>
        /// <param name="info">保存序列化对象<see cref="System.Runtime.Serialization.SerializationInfo"/>数据的对象。</param>
        /// <param name="context">有关源或目标的上下文信息。</param>
        protected MaydearException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }

}
