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
        /// 排序字段
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 是否降序
        /// </summary>
        public bool IsDesc { get; set; }
    }
}
