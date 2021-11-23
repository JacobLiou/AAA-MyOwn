#region using

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

#endregion

namespace ZCN.NET.Common.Extensions
{
    /// <summary>
    ///  使用表达式树技术，实现高性能（性能比AutoMapper高）的对象深度拷贝
    ///  调用方式：调用：StudentSecond ss= TransExpressionConvert<Student, StudentSecond>.Trans(s);
    /// </summary>
    /// <typeparam name="TIn">需要拷贝的对象</typeparam>
    /// <typeparam name="TOut">拷贝后的新对象</typeparam>
    public class TransExpressionConvert<TIn, TOut>
    {
        // 表达式树实现(性能较高)
        private static readonly Func<TIn, TOut> Cache = GetFunc();

        private static Func<TIn, TOut> GetFunc()
        {
            var tInType = typeof(TIn);
            var tOutType = typeof(TOut);

            List<MemberBinding> memberBindingList = new List<MemberBinding>();
            ParameterExpression parameterExpression = Expression.Parameter(tInType, "p");

            var tOutProperties = tOutType.GetProperties();
            foreach (var outItem in tOutProperties)
            {
                if (!outItem.CanWrite)
                    continue;

                var inPropertyInfo = tInType.GetProperty(outItem.Name);
                if (inPropertyInfo == null || inPropertyInfo.PropertyType != outItem.PropertyType)
                    continue;

                MemberExpression memberExpression = Expression.Property(parameterExpression, inPropertyInfo);
                MemberBinding memberBinding = Expression.Bind(outItem, memberExpression);
                memberBindingList.Add(memberBinding);
            }

            MemberInitExpression memberInitExpression = Expression.MemberInit(Expression.New(tOutType), memberBindingList.ToArray());
            Expression<Func<TIn, TOut>> lambda = Expression.Lambda<Func<TIn, TOut>>(memberInitExpression, parameterExpression);

            return lambda.Compile();
        }

        /// <summary>
        ///   将 Tin 输入对象转换为 TOut 对象
        /// </summary>
        /// <param name="tIn">被转换(拷贝)的对象</param>
        /// <returns></returns>
        public static TOut Trans(TIn tIn)
        {
            return Cache(tIn);
        }
    }
}