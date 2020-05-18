using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace Maydear.Extensions
{
    /// <summary>
    /// 列表泛型扩展
    /// </summary>
    public static class ListExtension
    {
        /// <summary>
        /// 将列表对象转为数据表格对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable AsDataTable<T>(this IList<T> data) where T : class
        {
            var properties = TypeDescriptor.GetProperties(typeof(T));
            var dataTable = new DataTable();
            for (var i = 0; i < properties.Count; i++)
            {
                var property = properties[i];
                dataTable.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
            }
            var values = new object[properties.Count];
            foreach (var item in data)
            {
                for (var i = 0; i < values.Length; i++)
                {
                    values[i] = properties[i].GetValue(item);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}
