using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear
{
    /// <summary>
    /// 分页查询
    /// </summary>
    public class PageQuery : Page
    {
        /// <summary>
        /// 关键字
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 排序降序序字段
        /// </summary>
        public string OrderByDesc { get; set; }

        /// <summary>
        /// 排序升序参数
        /// </summary>
        public string OrderBy{ get; set; }
    }
}
