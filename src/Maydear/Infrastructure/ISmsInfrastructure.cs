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

namespace Maydear.Infrastructure
{
    /// <summary>
    /// 短信内容
    /// </summary>
    public class Sms {

        /// <summary>
        /// 发送手机号码，多个手机号码","分割
        /// </summary>
        public string Mobiles { get; set; }

        /// <summary>
        /// 邮件正文
        /// </summary>
        public string Content { get; set; }
    }

    /// <summary>
    /// 短信服务
    /// </summary>
    public interface ISmsInfrastructure
    {
        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="sms">短信内容</param>
        /// <returns></returns>
        bool Send(Sms sms);
    }
}
