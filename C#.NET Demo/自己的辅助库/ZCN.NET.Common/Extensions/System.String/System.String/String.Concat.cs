using System.Collections.Generic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：连接 <see cref="T:System.String" /> 的两个指定实例
        /// </summary>
        /// <param name="str0"></param>
        /// <param name="str1"></param>
        /// <returns></returns>
        public static string Concat(this string str0, string str1)
        {
            return string.Concat(str0, str1);
        }

        /// <summary>
        /// 自定义扩展方法：连接 <see cref="T:System.String" /> 的三个指定实例
        /// </summary>
        /// <param name="str0"></param>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static string Concat(this string str0, string str1, string str2)
        {
            return string.Concat(str0, str1, str2);
        }

        /// <summary>
        /// 自定义扩展方法：连接 <see cref="T:System.String" /> 的四个指定实例
        /// </summary>
        /// <param name="str0"></param>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str3"></param>
        /// <returns></returns>
        public static string Concat(this string str0, string str1, string str2, string str3)
        {
            return string.Concat(str0, str1, str2, str3);
        }

        /// <summary>
        /// 自定义扩展方法：连接 <see cref="T:System.String" /> 的多个指定实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str0"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string Concat<T>(this string str0, IEnumerable<T> values)
        {
            return string.Concat(str0, string.Concat(values));
        }
    }
}