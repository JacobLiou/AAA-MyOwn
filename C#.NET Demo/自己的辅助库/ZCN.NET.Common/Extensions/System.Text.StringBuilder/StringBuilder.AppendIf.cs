using System;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将泛型数组中的所有元素循环传入委托函数并执行，
        ///  如果函数执行结果为true，则将元素追加到扩展对象结尾
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="predicate">泛型委托函数</param>
        /// <param name="values">泛型类型数组</param>
        /// <returns></returns>
        public static StringBuilder AppendIf<T>(this StringBuilder @this, Func<T, bool> predicate, params T[] values)
        {
            foreach (var value in values)
            {
                if (predicate(value))
                {
                    @this.Append(value);
                }
            }

            return @this;
        }
        
        /// <summary>
        ///  自定义扩展方法：将泛型数组中的所有元素循环传入委托函数并执行，
        ///  如果函数执行结果为true，则将元素追加到扩展对象结尾(带有换行符号) 
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="predicate">泛型委托函数</param>
        /// <param name="values">泛型类型数组</param>
        /// <returns></returns>
        public static StringBuilder AppendLineIf<T>(this StringBuilder @this, Func<T, bool> predicate, params T[] values)
        {
            foreach (var value in values)
            {
                if (predicate(value))
                {
                    @this.AppendLine(value.ToString());
                }
            }

            return @this;
        }
    }
}