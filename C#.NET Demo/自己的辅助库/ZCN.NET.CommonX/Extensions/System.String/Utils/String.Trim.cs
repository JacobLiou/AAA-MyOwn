using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：去除字符串中的所有空格
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string TrimAll(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return String.Empty;

            return @this.Replace(" ", "");
        }

        /// <summary>
        ///  自定义扩展方法：从当前 <see cref="T:System.String" /> 对象移除所有前导空白字符和尾部空白字符
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string Trim(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return String.Empty;

            return @this.Trim(@this.ToCharArray());
        }

        /// <summary>
        ///  自定义扩展方法：从当前 <see cref="T:System.String" /> 对象移除所有前导空白字符
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string TrimStart(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return String.Empty;

            return @this.TrimStart(@this.ToCharArray());
        }

        /// <summary>
        ///  自定义扩展方法：从当前 <see cref="T:System.String" /> 对象移除所有尾部空白字符
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string TrimEnd(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return String.Empty;

            return @this.TrimEnd(@this.ToCharArray());
        }
    }
}