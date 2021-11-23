using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断扩展对象的值是否存在于数组中
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="values">目标数组</param>
        /// <returns>如果数组包含对象，则为true，否则为false</returns>
        public static bool In(this Int16 @this, params Int16[] values)
        {
            return Array.IndexOf(values, @this) != -1;
        }

        /// <summary>
        /// 自定义扩展方法：判断扩展对象的值是否不存在于数组中
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="values">目标数组</param>
        /// <returns>如果数组包含对象，则为false，否则为true</returns>
        public static bool NotIn(this Int16 @this, params Int16[] values)
        {
            return Array.IndexOf(values, @this) == -1;
        }
    }
}
