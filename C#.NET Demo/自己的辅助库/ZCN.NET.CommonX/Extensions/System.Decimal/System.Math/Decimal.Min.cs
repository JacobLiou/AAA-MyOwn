using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回两个十进制数中较小的一个
        /// </summary>
        /// <param name="value1">扩展对象。要比较的两个 System.Decimal 数字中的第一个</param>
        /// <param name="value2">要比较的两个 System.Decimal 数字中的第二个</param>
        /// <returns>val1 或 val2 参数中较小的一个</returns>
        public static decimal Min(this decimal value1, decimal value2)
        {
            return Math.Min(value1,value2);
        }
    }
}