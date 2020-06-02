using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear.Infrastructure
{
    /// <summary>
    /// 简单Excel操作工厂
    /// </summary>
    public interface ISimpleExcelFactory
    {
        /// <summary>
        /// 获取Excel操作基础设施 2003格式
        /// </summary>
        /// <returns></returns>
        ISimpleExcelInfrastructure GetSimpleExcel03();

        /// <summary>
        /// 获取Excel操作基础设施 2007+格式
        /// </summary>
        /// <returns></returns>
        ISimpleExcelInfrastructure GetSimpleExcel07();
    }
}
