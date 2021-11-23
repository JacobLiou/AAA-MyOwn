using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断扩展对象的值是否介于最小值与最大值之间(包含边界值)
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="minValue">T类型的比较值下限</param>
        /// <param name="maxValue">T类型的比较值上限</param>
        /// <returns></returns>                                                       
        public static bool Between<T>(this T @this, T minValue, T maxValue) where T : IComparable<T>
        {
            return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
        }

        /// <summary>
        /// 自定义扩展方法：判断扩展对象的值是否介于最小值与最大值之间(不包含边界值)
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="minValue">T类型的比较值下限</param>
        /// <param name="maxValue">T类型的比较值上限</param>
        /// <returns></returns>
        public static bool BetweenExcludeBoundary<T>(this T @this, T minValue, T maxValue) where T : IComparable<T>
        {
            return @this.CompareTo(minValue) > 0 && @this.CompareTo(maxValue) < 0;
        }

        /// <summary>
        /// 自定义扩展方法：判断扩展对象的值是否介于最小值与最大值之外
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="minValue">T类型的比较值下限</param>
        /// <param name="maxValue">T类型的比较值上限</param>
        /// <returns></returns>
        public static bool NotBetween<T>(this T @this, T minValue, T maxValue) where T : IComparable<T>
        {
            return @this.CompareTo(minValue) < 0 || @this.CompareTo(maxValue) > 0;
        }
    }
}