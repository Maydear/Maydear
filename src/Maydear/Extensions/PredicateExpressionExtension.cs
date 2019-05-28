using System;
using System.Collections.Generic;
using System.Text;

namespace System.Linq.Expressions
{
    /// <summary>
    /// 判断表达式扩展
    /// </summary>
    public static class PredicateExpressionExtension
    {
        /// <summary>
        /// 参数表达式观察者
        /// </summary>
        private class ParameterExpressionVisitor : ExpressionVisitor
        {
            private readonly Dictionary<ParameterExpression, ParameterExpression> _dictionary;

            private ParameterExpressionVisitor(Dictionary<ParameterExpression, ParameterExpression> dictionary)
            {
                _dictionary = (dictionary ?? new Dictionary<ParameterExpression, ParameterExpression>());
            }

            public static Expression VisitParameters(Dictionary<ParameterExpression, ParameterExpression> dictionary, Expression expression)
            {
                return new ParameterExpressionVisitor(dictionary).Visit(expression);
            }

            protected override Expression VisitParameter(ParameterExpression p)
            {
                if (_dictionary.TryGetValue(p, out ParameterExpression parameterExpression))
                {
                    p = parameterExpression;
                }
                return base.VisitParameter(p);
            }
        }

        /// <summary>
        /// 表达式且合并
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sourceExpression">原表达式</param>
        /// <param name="pendingExpression">待合并的表达式</param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> sourceExpression, Expression<Func<T, bool>> pendingExpression)
        {
            return sourceExpression.Merge(pendingExpression, new Func<Expression, Expression, Expression>(Expression.AndAlso));
        }

        /// <summary>
        /// 或合并
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sourceExpression">原表达式</param>
        /// <param name="pendingExpression">待合并的表达式</param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> sourceExpression, Expression<Func<T, bool>> pendingExpression)
        {
            return sourceExpression.Merge(pendingExpression, new Func<Expression, Expression, Expression>(Expression.OrElse));
        }

        /// <summary>
        /// 合并操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sourceExpression">原表达式</param>
        /// <param name="pendingExpression">待合并的表达式</param>
        /// <param name="mergeFunc">合并后的表达式</param>
        /// <returns></returns>
        private static Expression<T> Merge<T>(this Expression<T> sourceExpression, Expression<T> pendingExpression, Func<Expression, Expression, Expression> mergeFunc)
        {
            Dictionary<ParameterExpression, ParameterExpression> dictionary = sourceExpression.Parameters.Select((ParameterExpression left, int i) => new
            {
                left,
                right = pendingExpression.Parameters[i]
            }).ToDictionary(p => p.right, p => p.left);
            Expression arg = ParameterExpressionVisitor.VisitParameters(dictionary, pendingExpression.Body);
            return Expression.Lambda<T>(mergeFunc(sourceExpression.Body, arg), sourceExpression.Parameters);
        }

    }
}
