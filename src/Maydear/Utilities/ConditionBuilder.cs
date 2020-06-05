using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Maydear.Utilities
{
    /// <summary>
    /// 条件构造器
    /// </summary>
    public static class ConditionBuilder
    {
        /// <summary>
        /// 或拼接
        /// </summary>
        /// <typeparam name="T">实体数据类型</typeparam>
        /// <param name="source">原条件</param>
        /// <param name="expression">待拼接的表达式</param>
        /// <returns>返回拼接后的表达式</returns>
        public static Expression<Func<T, bool>> AndJoin<T>(Expression<Func<T, bool>> source, Expression<Func<T, bool>> expression)
        {
            if (expression == null)
            {
                return source;
            }

            if (source == null)
            {
                source = expression;
            }
            else
            {
                source.And(expression);
            }

            return source;
        }

        /// <summary>
        /// 或拼接
        /// </summary>
        /// <typeparam name="T">实体数据类型</typeparam>
        /// <param name="source">原条件</param>
        /// <param name="expression">待拼接的表达式</param>
        /// <returns>返回拼接后的表达式</returns>
        public static Expression<Func<T, bool>> OrJoin<T>(Expression<Func<T, bool>> source, Expression<Func<T, bool>> expression)
        {
            if (expression == null)
            {
                return source;
            }

            if (source == null)
            {
                source = expression;
            }
            else
            {
                source.Or(expression);
            }

            return source;
        }
    }
}
