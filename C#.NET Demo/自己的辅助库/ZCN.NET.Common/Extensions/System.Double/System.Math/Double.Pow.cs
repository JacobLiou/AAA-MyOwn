using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回指定数字的指定次幂。
        /// 返回 数字 x 的 y 次幂
        /// </summary>
        /// <param name="x">扩展对象。要乘幂的双精度浮点数</param>
        /// <param name="y">指定幂的双精度浮点数</param>
        /// <returns></returns>
        public static double Pow(this double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}