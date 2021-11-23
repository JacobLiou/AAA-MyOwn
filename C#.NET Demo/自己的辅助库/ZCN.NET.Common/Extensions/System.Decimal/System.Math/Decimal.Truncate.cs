using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：计算指定小数的整数部分
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns>整数部分(即舍弃小数位后剩余的数)</returns>
        public static decimal Truncate(this decimal d)
        {
            return Math.Truncate(d);
        }
    }
}