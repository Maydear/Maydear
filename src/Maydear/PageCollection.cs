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
    public interface IPageCollection
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
    public interface IPageCollection<T> : IPageCollection
    {
        /// <summary>
        /// 数据集合
        /// </summary>
        IEnumerable<T> Data { get; set; }
    }

    /// <summary>
    /// 带分页的实体集合
    /// </summary>
    /// <typeparam name="T">带实例化的实体</typeparam>
    public class PageCollection<T> : IPageCollection<T>
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
        public int PageSize { get; set; } = Constants.DEFAULT_PAGE_SIZE;

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
        public IEnumerable<T> Data { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="data">数据集合</param>
        /// <param name="recordCount">总记录数</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">每次返回的最大数量</param>
        public PageCollection(IEnumerable<T> data, long recordCount, int pageIndex = Constants.DEFAULT_PAGE_INDEX, int pageSize = Constants.DEFAULT_PAGE_SIZE)
        {
            PageSize = pageSize;
            PageIndex = pageIndex;
            RecordCount = recordCount;
            Data = data;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public PageCollection(int pageIndex = Constants.DEFAULT_PAGE_INDEX, int pageSize = Constants.DEFAULT_PAGE_SIZE)
        { }
    }

    /// <summary>
    /// 分页实体
    /// </summary>
    /// <typeparam name="T">带实例化的实体</typeparam>
    public class PageList<T> : PageCollection<T>, IPageCollection<T>
    {
        /// <summary>
        /// 列表集合
        /// </summary>
        public new IList<T> Data { get; set; }

        /// <summary>
        /// 构造一个分页列表实体
        /// </summary>
        /// <param name="data">列表实体集合</param>
        /// <param name="recordCount">总记录数</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页宽</param>
        public PageList(IList<T> data, long recordCount, int pageIndex, int pageSize) : base(data, recordCount, pageIndex, pageSize)
        {
            PageSize = pageSize;
            PageIndex = pageIndex;
            RecordCount = recordCount;
            Data = data;
        }

        /// <summary>
        /// 构造一个分页列表实体
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页宽</param>
        public PageList(int pageIndex = Constants.DEFAULT_PAGE_INDEX, int pageSize = Constants.DEFAULT_PAGE_SIZE) : base(pageIndex, pageSize)
        { }
    }
}
