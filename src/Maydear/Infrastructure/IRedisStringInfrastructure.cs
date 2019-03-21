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
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maydear.Infrastructure
{
    /// <summary>
    /// Redis操作接口
    /// </summary>
    public interface IRedisStringInfrastructure : IDisposable
    {
        /// <summary>
        /// 读取Redis指定的键值
        /// </summary>
        /// <param name="key">待获取数据的键</param>
        /// <returns></returns>
        string Get(string key);

        /// <summary>
        ///  异步读取Redis指定的键值
        /// </summary>
        /// <param name="key">待获取数据的键值</param>
        /// <param name="cancellationToken">线程销毁令牌</param>
        /// <returns></returns>
        Task<string> GetAsync(string key, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 将指定的键及对应的值设置到Redis
        /// </summary>
        /// <param name="key">待设置数据的键</param>
        /// <param name="value">待设置的数据</param>
        /// <param name="expiry">过期时间</param>
        void Set(string key, string value, TimeSpan? expiry = null);

        /// <summary>
        /// 将指定的键及对应的值设置到Redis
        /// </summary>
        /// <param name="key">待设置数据的键</param>
        /// <param name="value">待设置的数据</param>
        /// <param name="expiry">过期时间</param>
        /// <param name="cancellationToken">线程销毁令牌</param>
        /// <returns></returns>
        Task SetAsync(string key, string value, TimeSpan? expiry = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="key">刷新的键</param>
        /// <param name="expiry">刷新时间</param>
        void Refresh(string key, TimeSpan? expiry);

        /// <summary>
        /// 异步刷新
        /// </summary>
        /// <param name="key">刷新的键</param>
        /// <param name="expiry">刷新时间</param>
        /// <param name="token">异步销毁令牌</param>
        /// <returns></returns>
        Task RefreshAsync(string key, TimeSpan? expiry, CancellationToken token = default(CancellationToken));

        /// <summary>
        /// 移除指定键
        /// </summary>
        /// <param name="key">待移除的键</param>
        void Remove(string key);

        /// <summary>
        /// 异步移除指定键
        /// </summary>
        /// <param name="key">待移除的键</param>
        /// <param name="token">异步销毁令牌</param>
        Task RemoveAsync(string key, CancellationToken token = default(CancellationToken));
    }
}
