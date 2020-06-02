using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Maydear.Extensions
{
    /// <summary>
    /// 数据表格对象扩展
    /// </summary>
    public static class DataTableExtension
    {

        /// <summary>
        /// 将数据表格对象转为列表对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public static IList<T> AsList<T>(this DataTable table) where T : class
        {
            if (table == null)
            {
                return null;
            }

            var rows = new List<DataRow>();
            foreach (DataRow row in table.Rows)
            {
                rows.Add(row);
            }
            return rows.AsObject<T>();
        }
    }
}
