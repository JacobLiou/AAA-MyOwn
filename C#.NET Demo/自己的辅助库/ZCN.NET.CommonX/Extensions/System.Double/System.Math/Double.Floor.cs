using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回小于或等于指定双精度浮点数的最大整数。
        /// 返回小于或等于 浮点数 的最大整数。
        /// 如果 浮点数 等于 System.Double.NaN、System.Double.NegativeInfinity 或 
        /// System.Double.PositiveInfinity，则返回该值
        /// </summary>
        /// <param name="d">扩展对象。双精度浮点数</param>
        /// <returns></returns>
        public static double Floor(this double d)
        {
            return Math.Floor(d);
        }
    }
}