using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回指定角度的正切值。
        /// 如果 角度 等于 System.Double.NaN、System.Double.NegativeInfinity 或 System.Double.PositiveInfinity，
        /// 此方法将返回System.Double.NaN
        /// </summary>
        /// <param name="a">扩展对象。以弧度为单位的角</param>
        /// <returns></returns>
        public static double Tan(this double a)
        {
            return Math.Tan(a);
        }
    }
}