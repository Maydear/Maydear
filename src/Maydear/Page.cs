using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear
{
    /// <summary>
    /// 分页查询
    /// </summary>
    public class Page
    {
        /// <summary>
        /// 页宽
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex { get; set; } = Constants.DEFAULT_PAGE_INDEX;

        /// <summary>
        /// 偏移量
        /// </summary>
        public int? Offset
        {
            get
            {
                if (!PageSize.HasValue)
                {
                    return 0;
                }

                if (PageIndex <= 0)
                {
                    return 0;
                }

                return (PageIndex - 1) * PageSize;
            }
        }

        /// <summary>
        /// 范围
        /// </summary>
        public int? Limit => PageSize;
    }
}
