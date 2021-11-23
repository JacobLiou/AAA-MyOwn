using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定的索引是否存在于数组中
        /// </summary>
        /// <param name="this">扩展对象。一维 System.Array 数组</param>
        /// <param name="index">指定的索引</param>
        /// <returns></returns>
        public static bool WithinIndex(this Array @this, int index)
        {
            return index >= 0 && index < @this.Length;
        }

        /// <summary>
        /// 自定义扩展方法：判断指定的索引是否存在于数组中
        /// </summary>
        /// <param name="this">扩展对象。一维 System.Array 数组</param>
        /// <param name="index">指定的索引</param>
        /// <param name="dimension">维度</param>
        /// <returns></returns>
        public static bool WithinIndex(this Array @this, int index, int dimension)
        {
            return index >= @this.GetLowerBound(dimension) && index <= @this.GetUpperBound(dimension);
        }
    }
}