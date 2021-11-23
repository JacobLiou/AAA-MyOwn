using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断字符串中是否包含字符数组中的所有元素
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="values">字符数组</param>
        /// <returns>全部包含返回true，否则返回false</returns>
        public static bool ContainsAll(this string @this, params string[] values)
        {
            foreach(string value in values)
            {
                if(@this.IndexOf(value, StringComparison.Ordinal) == -1)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        ///  自定义扩展方法：判断字符串中是否包含字符数组中的所有元素
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="comparisonType">指定搜索规则的枚举值之一</param>
        /// <param name="values">字符数组</param>
        /// <returns>全部包含返回true，否则返回false</returns>
        public static bool ContainsAll(this string @this, StringComparison comparisonType, params string[] values)
        {
            foreach(string value in values)
            {
                if(@this.IndexOf(value, comparisonType) == -1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}