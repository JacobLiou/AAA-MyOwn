using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region GreaterThan
        /// <summary>
        /// 自定义扩展方法：判断扩展对象的值是否大于目标值
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="targetValue">T类型的比较值</param>
        /// <returns></returns>
        public static bool GreaterThan<T>(this T @this,T targetValue) where T : IComparable<T>
        {
            return @this.CompareTo(targetValue) > 0;
        }

        /// <summary>
        /// 自定义扩展方法：判断扩展对象的值是否大于等于目标值
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="targetValue">T类型的比较值</param>
        /// <returns></returns>
        public static bool GreaterThanEqual<T>(this T @this,T targetValue) where T : IComparable<T>
        {
            return @this.CompareTo(targetValue) >= 0;
        }

        #endregion
    }
}