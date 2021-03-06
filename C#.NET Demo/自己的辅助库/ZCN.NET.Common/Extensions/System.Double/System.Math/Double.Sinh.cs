using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回指定角度的双曲正弦值。
        /// 如果 角度 等于 System.Double.NaN、System.Double.NegativeInfinity 或 
        /// System.Double.PositiveInfinity，此方法将返回 System.Double.NaN
        /// </summary>
        /// <param name="value">扩展对象。以弧度为单位的角</param>
        /// <returns></returns>
        public static double Sinh(this double value)
        {
            return Math.Sinh(value);
        }
    }
}