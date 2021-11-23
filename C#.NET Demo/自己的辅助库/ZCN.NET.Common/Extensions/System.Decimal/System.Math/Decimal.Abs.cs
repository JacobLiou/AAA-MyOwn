using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回 16 位有符号整数的绝对值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>绝对值</returns>
        public static decimal Abs(this decimal value)
        {
            return Math.Abs(value);
        }
    }
}