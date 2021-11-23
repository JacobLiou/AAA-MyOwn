using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回正切值为指定数字的角度。
        /// 角度 θ，以弧度为单位，满足 -π/2 ≤θ≤π/2。
        /// 如果 正切值 等于 System.Double.NaN，则为 System.Double.NaN；
        /// 如果 正切值 等于 System.Double.NegativeInfinity，则为舍入为双精度值 (-1.5707963267949) 的 -π/2；
        /// 如果 正切值 等于 System.Double.PositiveInfinity，则为舍入为双精度值 (1.5707963267949) 的 π/2
        /// </summary>
        /// <param name="d">扩展对象。表示正切值的数字</param>
        /// <returns></returns>
        public static double Atan(this double d)
        {
            return Math.Atan(d);
        }
    }
}