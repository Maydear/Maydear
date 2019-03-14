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
