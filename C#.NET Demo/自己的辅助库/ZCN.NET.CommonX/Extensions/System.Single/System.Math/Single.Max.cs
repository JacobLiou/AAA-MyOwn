using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回两个单精度浮点数中较大的一个
        /// </summary>
        /// <param name="val1">扩展对象。要比较的两个单精度浮点数中的第一个</param>
        /// <param name="val2">要比较的两个单精度浮点数中的第二个</param>
        /// <returns></returns>
        public static Single Max(this Single val1,Single val2)
        {
            return Math.Max(val1, val2);
        }
    }
}