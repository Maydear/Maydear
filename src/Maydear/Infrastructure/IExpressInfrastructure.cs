using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear.Infrastructure
{
    /// <summary>
    /// 快递相关人员信息
    /// </summary>
    public class ExpressHolder
    {
        /// <summary>
        /// 公司名称
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// 联系手机
        /// </summary>
        public string Mobile { get; set; }


        /// <summary>
        /// 所在省份省名称称谓 如:广东省,如果是 直辖市, 请直接传北京、上海等。
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 城市名称[必须是标准的城市称谓]
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 县/区
        /// </summary>
        public string County { get; set; }
        /// <summary>
        /// 详细地址,包括省市区,
        /// </summary>
        public string Address { get; set; }
    }

    /// <summary>
    /// 快递订单
    /// </summary>
    public class ExpressOrder
    {

    }

    /// <summary>
    /// 快递接口
    /// </summary>
    public interface IExpressInfrastructure
    {
        ExpressOrder CommitOrder();
        //
    }
}
