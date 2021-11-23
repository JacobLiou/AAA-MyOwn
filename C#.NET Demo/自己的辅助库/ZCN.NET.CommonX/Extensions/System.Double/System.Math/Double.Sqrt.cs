using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回指定数字的平方根。
        /// 参数返回值零或正数d 的正平方根。负System.Double.NaN 等于 System.Double.NaN；
        /// System.Double.NaN 等于System.Double.PositiveInfinity
        /// </summary>
        /// <param name="d">扩展对象。数字</param>
        /// <returns></returns>
        public static double Sqrt(this double d)
        {
            return Math.Sqrt(d);
        }
    }
}