using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回指定角度的双曲正切值。
        /// 如果 value 等于 System.Double.NegativeInfinity，则此方法返回 -1。
        /// 如果值等于 System.Double.PositiveInfinity，则此方法返回 1。
        /// 如果 value 等于 System.Double.NaN，则此方法返回 System.Double.NaN
        /// </summary>
        /// <param name="value">扩展对象。以弧度为单位的角</param>
        /// <returns></returns>
        public static double Tanh(this double value)
        {
            return Math.Tanh(value);
        }
    }
}