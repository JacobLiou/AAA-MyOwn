using System;
using System.Collections.Generic;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将集合中的所有元素串联成一个字符串并返回串联后的字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>字符串</returns>
        public static string Concatenate(this IEnumerable<string> @this)
        {
            return string.Concat(@this);
        }

        /// <summary>
        ///  自定义扩展方法：将指定分隔符串联集合中的所有元素并返回串联后的字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="separator">要用作分隔符的字符串</param>
        /// <returns>字符串</returns>
        public static string Concatenate(this IEnumerable<string> @this,string separator)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var s in @this)
            {
                sb.Append(s + separator);
            }

            string temp = sb.ToString();
            temp = temp.Remove(temp.LastIndexOf(separator, StringComparison.Ordinal));//移除最后一个分隔符

            return temp;
        }

        /// <summary>
        ///  自定义扩展方法：将集合中的所有元素循环传入委托函数并执行，将函数的返回结果串联成一个字符串并返回</summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="source">扩展对象</param>
        /// <param name="func">委托函数</param>
        /// <returns>字符串</returns>
        public static string Concatenate<T>(this IEnumerable<T> source, Func<T, string> func)
        {
            var sb = new StringBuilder();
            foreach(var item in source)
            {
                sb.Append(func(item));
            }

            return sb.ToString();
        }

        /// <summary>
        ///  自定义扩展方法：将集合中的所有元素循环传入并执行委托函数，将指定分隔符将函数的返回结果串联成一个字符串并返回</summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="source">扩展对象</param>
        /// <param name="func">委托函数</param>
        /// <param name="separator">要用作分隔符的字符串</param>
        /// <returns>字符串</returns>
        public static string Concatenate<T>(this IEnumerable<T> source,Func<T,string> func,string separator)
        {
            var sb = new StringBuilder();
            foreach(var item in source)
            {
                sb.Append(func(item) + separator);
            }

            string temp = sb.ToString();
            temp = temp.Remove(temp.LastIndexOf(separator,StringComparison.Ordinal));//移除最后一个分隔符

            return temp;
        }
    }
}