using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回 e 的指定次幂。
        /// 返回数字 e 的 d 次幂。如果 d 等于 System.Double.NaN 或 System.Double.PositiveInfinity，则返回该值。
        /// 如果 d 等于 System.Double.NegativeInfinity，则返回 0
        /// </summary>
        /// <param name="d">扩展对象。指定幂的数字</param>
        /// <returns></returns>
        public static double Exp(this double d)
        {
            return Math.Exp(d);
        }
    }
}