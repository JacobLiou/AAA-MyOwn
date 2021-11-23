using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回正弦值为指定数字的角度。
        /// 返回角度 θ，以弧度为单位，满足 θ (介于-π/2到π/2之间)。
        /// 如果余弦值大于1或者小于-1则返回 System.Double.NaN
        /// </summary>
        /// <param name="d">扩展对象。表示正弦值的数字(介于-1到1之间)</param>
        /// <returns></returns>
        public static double Asin(this double d)
        {
            return Math.Asin(d);
        }
    }
}