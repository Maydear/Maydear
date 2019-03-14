/*****************************************************************************************
* Copyright 2014-2017 The Maydear Authors
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
using System.Threading;
using System.Threading.Tasks;

/*****************************************************************************************
 * FileName:StringFilterExtension.cs
 * Author:Kelvin
 * CreateDate:2014/09/22 15:02:45
 * Description:
 *        对于Task异步任务，需要使用多个任务等待完成时的异常判断处理。
 *        <version>	|	<author>	|<time>			        |	<desc>
 *        1		    |	Kelvin		|2014-09-22 15:20:00	|	创建文件
 ****************************************************************************************/

namespace Maydear.Utilities
{
    /// <summary>
    /// 异步助手类
    /// </summary>
    public static class TaskHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="task"></param>
        /// <param name="tcs"></param>
        /// <returns></returns>
        public static bool HandleFaultsAndCancelation<T>(Task task, TaskCompletionSource<T> tcs)
        {
            if (task.IsFaulted)
            {
                tcs.TrySetException(task.Exception.GetBaseException());
                return true;
            }
            if (task.IsCanceled)
            {
                tcs.TrySetCanceled();
                return true;
            }
            return false;
        }

        /// <summary>
        /// 主要对Task的ContinueWith方法抽象出一个标准的通用调用。
        /// </summary>
        /// <param name="task">任务</param>
        /// <param name="continuation">Continuation委托</param>
        /// <returns></returns>
        public static Task ContinueWithStandard(this Task task, Action<Task> continuation)
        {
            return task.ContinueWith(continuation, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
        }

        /// <summary>
        /// 主要对Task的ContinueWith方法抽象出一个标准的通用调用。
        /// </summary>
        /// <typeparam name="T">泛型任务</typeparam>
        /// <param name="task">任务</param>
        /// <param name="continuation">Continuation委托</param>
        /// <returns></returns>
        public static Task ContinueWithStandard<T>(this Task<T> task, Action<Task<T>> continuation)
        {
            return task.ContinueWith(continuation, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
        }
    }
}
