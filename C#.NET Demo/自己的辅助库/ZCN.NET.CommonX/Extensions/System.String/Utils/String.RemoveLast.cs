using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从字符串中最后一次出现的内容的位置开始删除
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="value">字符串中最后一次出现的内容</param>
        /// <returns></returns>
        public static string RemoveLast(this string @this, string value)
        {
            if (@this.IsNullOrWhiteSpace())
                return string.Empty;

            @this = @this.Remove(@this.LastIndexOf(value, StringComparison.Ordinal));
            return @this;
        }

        /// <summary>
        ///  自定义扩展方法：从字符串中最后一次出现的内容的位置开始删除指定数目的字符
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="value">字符串中最后一次出现的内容</param>
        /// <param name="count">要删除的字符数</param>
        /// <returns></returns>
        public static string RemoveLast(this string @this, string value, int count)
        {
            if (@this.IsNullOrWhiteSpace())
                return string.Empty;

            @this = @this.Remove(@this.LastIndexOf(value, StringComparison.Ordinal), count);
            return @this;
        }
    }
}