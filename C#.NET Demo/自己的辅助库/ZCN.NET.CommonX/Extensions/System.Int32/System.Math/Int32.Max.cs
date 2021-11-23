using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回两个 32 位有符号的整数中较大的一个
        /// </summary>
        /// <param name="value1">扩展对象。要比较的两个 32 位有符号的整数中的第一个</param>
        /// <param name="value2">要比较的两个 32 位有符号的整数中的第二个</param>
        /// <returns></returns>
        public static int Max(this Int32 value1, Int32 value2)
        {
            return Math.Max(value1,value2);
        }

        /// <summary>
        ///  自定义扩展方法：返回两个 32 位无符号的整数中较大的一个
        /// </summary>
        /// <param name="value1">扩展对象。要比较的两个 32 位无符号的整数中的第一个</param>
        /// <param name="value2">要比较的两个 32 位无符号的整数中的第二个</param>
        /// <returns></returns>
        public static uint Max(this UInt32 value1,UInt32 value2)
        {
            return Math.Max(value1,value2);
        }
    }
}