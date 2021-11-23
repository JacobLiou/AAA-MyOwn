using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：(取余数运算)返回一指定数字被另一指定数字相除的余数。
        /// 该数等于 x - ( y Q)，其中 Q 是 x / y 的商的最接近整数（如果 x / y 在两个整数中间，则返回偶数）。
        /// 如果 x - ( y Q) 为零，则在 x 为正时返回值 +0，而在 x 为负时返回 -0。如果 y 等于 0，则返回 System.Double.NaN
        /// </summary>
        /// <param name="x">扩展对象。被除数</param>
        /// <param name="y">除数</param>
        /// <returns></returns>
        public static double IEEERemainder(this double x, double y)
        {
            if(y == 0)
                return 0;

            return Math.IEEERemainder(x, y);
        }
    }
}