using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region Max

        /// <summary>
        /// 自定义扩展方法：返回两个 8 位无符号整数中较大的一个
        /// </summary>
        /// <param name="val1">要比较的两个 8 位无符号整数中的第一个</param>
        /// <param name="val2">要比较的两个 8 位无符号整数中的第二个</param>
        /// <returns></returns>
        public static Byte Max(this Byte val1, Byte val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>
        /// 自定义扩展方法：返回两个 8 位有符号整数中较大的一个
        /// </summary>
        /// <param name="val1">要比较的两个 8 位有符号整数中的第一个</param>
        /// <param name="val2">要比较的两个 8 位有符号整数中的第二个</param>
        /// <returns></returns>
        public static SByte Max(this SByte val1, SByte val2)
        {
            return Math.Max(val1, val2);
        }

        #endregion

        #region Min
        /// <summary>
        /// 自定义扩展方法：返回两个 8 位无符号整数中较小的一个
        /// </summary>
        /// <param name="val1">要比较的两个 8 位无符号整数中的第一个</param>
        /// <param name="val2">要比较的两个 8 位无符号整数中的第二个</param>
        /// <returns></returns>
        public static Byte Min(this Byte val1, Byte val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>
        /// 自定义扩展方法：返回两个 8 位有符号整数中较小的一个
        /// </summary>
        /// <param name="val1">要比较的两个 8 位有符号整数中的第一个</param>
        /// <param name="val2">要比较的两个 8 位有符号整数中的第二个</param>
        /// <returns></returns>
        public static SByte Min(this SByte val1, SByte val2)
        {
            return Math.Min(val1, val2);
        }
        #endregion

        /// <summary>
        ///  自定义扩展方法：返回 8 位有符号整数的绝对值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>绝对值</returns>
        public static SByte Abs(this SByte value)
        {
            return Math.Abs(value);
        }

        /// <summary>
        ///  自定义扩展方法：返回一个值，该值表示 8 位有符号整数的符号
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>一个指示 value 的符号的数字，如下表所示。返回值含义-1value 小于零。0value 等于零。1value 大于零</returns>
        public static int Sign(this sbyte value)
        {
            return Math.Sign(value);
        }
    }
}