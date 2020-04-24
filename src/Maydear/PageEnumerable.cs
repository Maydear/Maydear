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

namespace Maydear
{
    /// <summary>
    /// 带分页的实体集合
    /// </summary>
    public interface IPageEnumerable
    {
        /// <summary>
        /// 页宽
        /// </summary>
        int PageSize { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        int PageIndex { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        int PageCount { get; }

        /// <summary>
        /// 总记录数
        /// </summary>
        long RecordCount { get; set; }
    }

    /// <summary>
    /// 带分页的实体集合
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPageEnumerable<T> : IPageEnumerable
    {
        /// <summary>
        /// 数据集合
        /// </summary>
        IEnumerable<T> Records { get; set; }
    }

    /// <summary>
    /// 带分页的实体集合
    /// </summary>
    /// <typeparam name="T">带实例化的实体</typeparam>
    public class PageEnumerable<T> : IPageEnumerable<T>
    {
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount
        {
            get
            {
                if (RecordCount == 0)
                {
                    return 0;
                }

                if (PageSize <= 0)
                {
                    return (int)RecordCount;
                }

                return (int)Math.Ceiling(RecordCount / (decimal)PageSize);
            }
        }

        /// <summary>
        /// 页宽
        /// </summary>
        public int PageSize { get; set; } = Constants.DefaultPageSize;

        /// <summary>
        /// 页码
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        public long RecordCount { get; set; }

        /// <summary>
        /// 数据集合
        /// </summary>
        public IEnumerable<T> Records { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="records">数据集合</param>
        /// <param name="recordCount">总记录数</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">每次返回的最大数量</param>
        public PageEnumerable(IEnumerable<T> records, long recordCount, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            RecordCount = recordCount;
            Records = records;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="records">数据集合</param>
        /// <param name="recordCount">总记录数</param>
        public PageEnumerable(IEnumerable<T> records, long recordCount)
            : this(records, recordCount, Constants.DefaultPageIndex, Constants.DefaultPageSize)
        { }

        /// <summary>
        /// 构造函数
        /// </summary>
        public PageEnumerable(int pageIndex, int pageSize)
            : this(default, 0, pageIndex, pageSize)
        { }

        /// <summary>
        /// 构造函数
        /// </summary>
        public PageEnumerable()
            : this(Constants.DefaultPageIndex, Constants.DefaultPageSize)
        { }
    }

    /// <summary>
    /// 分页实体
    /// </summary>
    /// <typeparam name="T">带实例化的实体</typeparam>
    public class PageList<T> : PageEnumerable<T>
    {
        /// <summary>
        /// 列表集合
        /// </summary>
        public new IList<T> Records { get; set; }

        /// <summary>
        /// 构造一个分页列表实体
        /// </summary>
        /// <param name="records">列表实体集合</param>
        /// <param name="recordCount">总记录数</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页宽</param>
        public PageList(IList<T> records, long recordCount, int pageIndex, int pageSize)
            : base(records, recordCount, pageIndex, pageSize)
        {
        }

        /// <summary>
        /// 构造一个分页列表实体
        /// </summary>
        /// <param name="records">列表实体集合</param>
        /// <param name="recordCount">总记录数</param>
        public PageList(IList<T> records, long recordCount) 
            : base(records, recordCount)
        { }

        /// <summary>
        /// 构造一个分页列表实体
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页宽</param>
        public PageList(int pageIndex, int pageSize) 
            : base(pageIndex, pageSize)
        {

        }

        /// <summary>
        /// 构造一个分页列表实体
        /// </summary>
        public PageList() : base()
        { }
    }
}
