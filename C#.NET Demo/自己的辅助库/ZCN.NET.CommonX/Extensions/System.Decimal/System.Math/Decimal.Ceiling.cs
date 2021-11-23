using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回大于或等于指定的十进制数的最小整数值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>大于或等于指定的十进制数的最小整数值</returns>
        public static decimal Ceiling(this decimal value)
        {
            return Math.Ceiling(value);
        }
    }
}