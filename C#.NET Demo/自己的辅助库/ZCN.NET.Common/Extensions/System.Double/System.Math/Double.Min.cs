using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回两个双精度浮点数字中较小的一个
        /// </summary>
        /// <param name="val1">扩展对象。要比较的两个双精度浮点数中的第一个</param>
        /// <param name="val2">要比较的两个双精度浮点数中的第二个</param>
        /// <returns></returns>
        public static double Min(this double val1, double val2)
        {
            return Math.Min(val1, val2);
        }
    }
}