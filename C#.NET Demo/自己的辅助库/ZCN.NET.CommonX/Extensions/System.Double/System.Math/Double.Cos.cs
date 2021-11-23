using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回指定角度的余弦值。
        /// 如果 角度 等于 System.Double.NaN、System.Double.NegativeInfinity 或 
        /// System.Double.PositiveInfinity，此方法将返回 System.Double.NaN
        /// </summary>
        /// <param name="d">扩展对象。以弧度为单位的角</param>
        /// <returns></returns>
        public static double Cos(this double d)
        {
            return Math.Cos(d);
        }
    }
}