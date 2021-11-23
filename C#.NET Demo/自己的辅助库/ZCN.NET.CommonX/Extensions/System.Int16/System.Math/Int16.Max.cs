using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回两个 16 位有符号的整数中较大的一个
        /// </summary>
        /// <param name="value1">扩展对象。要比较的两个 16 位有符号的整数中的第一个</param>
        /// <param name="value2">要比较的两个 16 位有符号的整数中的第二个</param>
        /// <returns></returns>
        public static Int16 Max(this Int16 value1, Int16 value2)
        {
            return Math.Max(value1, value2);
        }

        /// <summary>
        ///  自定义扩展方法：返回两个 16 位无符号的整数中较大的一个
        /// </summary>
        /// <param name="value1">扩展对象。要比较的两个 16 位无符号的整数中的第一个</param>
        /// <param name="value2">要比较的两个 16 位无符号的整数中的第二个</param>
        /// <returns></returns>
        public static UInt16 Max(this UInt16 value1, UInt16 value2)
        {
            return Math.Max(value1, value2);
        }
    }
}