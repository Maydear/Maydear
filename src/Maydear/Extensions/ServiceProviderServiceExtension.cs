using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear.Extensions
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class ServiceProviderServiceExtension
    {
        /// <summary>
        /// 获取指定的DI泛型对象
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="provider">服务供给实例</param>
        /// <returns>返回已经在DI中注册的实例，如果未注册则返回null</returns>
        public static T GetService<T>(this IServiceProvider provider)
          => (T)provider.GetService(typeof(T));
    }
}
