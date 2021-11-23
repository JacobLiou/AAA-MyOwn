using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回小于或等于指定小数的最大整数
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>小于或等于指定小数的最大整数</returns>
        public static decimal Floor(this decimal value)
        {
            return Math.Floor(value);
        }
    }
}