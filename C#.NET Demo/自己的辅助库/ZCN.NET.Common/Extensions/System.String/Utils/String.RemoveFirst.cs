using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从字符串起始位置开始删除到第一次出现的内容的位置结束
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="value">字符串中第一次出现的内容</param>
        /// <returns></returns>
        public static string RemoveFirst(this string @this, string value)
        {
            if (@this.IsNullOrWhiteSpace())
                return string.Empty;

            @this = @this.Remove(0, @this.IndexOf(value, StringComparison.Ordinal) + 1);
            return @this;
        }
    }
}