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
using System.Threading;
using System.Threading.Tasks;

namespace Maydear.Infrastructure
{
    /// <summary>
    /// 短信发送模式
    /// </summary>
    public enum SmsSendMode
    {
        /// <summary>
        /// 以正文方式发送
        /// </summary>
        Content = 0,

        /// <summary>
        /// 模板方式发送
        /// </summary>
        TemplateCode = 1
    }

    /// <summary>
    /// 短信内容
    /// </summary>
    public class Sms
    {
        /// <summary>
        /// 短信发送模式
        /// </summary>
        public SmsSendMode Mode { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public IEnumerable<Telephone> Telephones { get; set; }

        /// <summary>
        /// 短信正文
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 模板码
        /// </summary>
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模板参数
        /// </summary>
        public IDictionary<string, string> TemplateParameters { get; set; }
    }

    /// <summary>
    /// 电话
    /// </summary>
    public class Telephone
    {
        /// <summary>
        /// 国家代码
        /// </summary>
        public string NationCode { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string PhoneNumber { get; set; }
    }

    /// <summary>
    /// 短信服务
    /// </summary>
    public interface ISmsInfrastructure
    {
        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="sms">短信</param>
        /// <returns></returns>
        bool Send(Sms sms);

        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="smsFunc">短信委托</param>
        /// <returns></returns>
        bool Send(Func<Sms> smsFunc);

        /// <summary>
        /// 异步发送短信
        /// </summary>
        /// <param name="sms">短信</param>
        /// <param name="canceltoken">取消令牌</param>
        /// <returns></returns>
        Task<bool> SendAsync(Sms sms, CancellationToken canceltoken = default);

        /// <summary>
        /// 异步发送短信
        /// </summary>
        /// <param name="smsFunc">短信委托</param>
        /// <param name="canceltoken">取消令牌</param>
        /// <returns></returns>
        Task<bool> SendAsync(Func<Sms> smsFunc, CancellationToken canceltoken = default);

    }
}
