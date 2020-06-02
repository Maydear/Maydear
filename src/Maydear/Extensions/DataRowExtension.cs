using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Maydear.Extensions
{
    /// <summary>
    /// DataRow扩展
    /// </summary>
    public static class DataRowExtension
    {

        /// <summary>
        /// DataRow 转为泛型对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="row"></param>
        /// <returns></returns>
        public static T AsObject<T>(this DataRow row) where T : class
        {
            var obj = default(T);
            if (row != null && row.Table != null && row.Table.Columns != null)
            {
                obj = Activator.CreateInstance<T>();

                foreach (DataColumn column in row.Table.Columns)
                {
                    var prop = obj.GetType().GetProperty(column.ColumnName);
                    try
                    {
                        var value = row[column.ColumnName];
                        prop.SetValue(obj, value, null);
                    }
                    catch
                    {  //You can log something here     
                       //throw;    
                    }
                }
            }

            return obj;
        }

        /// <summary>
        /// DataRow 转为泛型对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rows"></param>
        /// <returns></returns>
        public static IList<T> AsObject<T>(this IEnumerable<DataRow> rows) where T : class
        {
            return rows?.Select(a => AsObject<T>(a)).ToList();
        }

    }
}
