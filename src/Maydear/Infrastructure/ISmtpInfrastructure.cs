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
using System.Text;

namespace Maydear.Infrastructure
{
    /// <summary>
    /// 邮件内容
    /// </summary>
    public class Email
    {
        /// <summary>
        /// 发送邮件地址
        /// </summary>
        public string FromAddress { get; set; }

        /// <summary>
        /// 对方邮件地址","分割多个地址
        /// </summary>
        public string ToAddress { get; set; }

        /// <summary>
        /// 邮件标题
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 邮件正文
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 邮件文本编码
        /// </summary>
        public Encoding TextEncoding { get; set; }

        /// <summary>
        /// 使用Body为HTML
        /// </summary>
        public bool UseBodyHtml { get; set; } = true;

        /// <summary>
        /// 重要等级
        /// </summary>
        public Priority Priority { get; set; } = Priority.Normal;
    }

    /// <summary>
    /// 重要等级
    /// </summary>
    public enum Priority
    {

        /// <summary>
        /// 正常
        /// </summary>
        Normal = 0,

        /// <summary>
        /// 低
        /// </summary>
        Low = 1,

        /// <summary>
        /// 高
        /// </summary>
        High = 2
    }

    /// <summary>
    /// Smtp服务基础设施
    /// </summary>
    public interface ISmtpInfrastructure
    {
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        bool Send(Email content);
    }
}
