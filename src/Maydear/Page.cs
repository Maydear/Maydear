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
        public int PageIndex { get; set; } = Constants.DefaultPageIndex;

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
