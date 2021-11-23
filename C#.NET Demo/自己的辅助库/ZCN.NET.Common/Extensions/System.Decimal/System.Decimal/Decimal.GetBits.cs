using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将 System.Decimal 的指定实例的值转换为其等效的二进制表示形式
        /// </summary>
        /// <param name="d">扩展对象</param>
        /// <returns>包含decimal值的二进制表示形式、由四个元素组成的 32 位有符号整数数组</returns>
        public static int[] GetBits(this decimal d)
        {
            return decimal.GetBits(d);
        }

#if NETSTANDARD2_1

        ///// <summary>
        /////  自定义扩展方法：将 System.Decimal 的指定实例的值转换为其等效的二进制表示形式
        ///// </summary>
        ///// <param name="d">扩展对象</param>
        ///// <param name="destination">要用于存储二进制表示形式的范围</param>
        ///// <returns>包含decimal值的二进制表示形式、由四个元素组成的 32 位有符号整数数组</returns>
        //public static int GetBits(this decimal d, Span<int> destination)
        //{
        //    return decimal.GetBits(d, destination);
        //}

        ///// <summary>
        /////  自定义扩展方法：尝试将 Decimal 的指定实例的值转换为其等效的二进制表示形式
        ///// </summary>
        ///// <param name="d">扩展对象</param>
        ///// <param name="destination">要用于存储二进制表示形式的范围</param>
        ///// <returns>包含decimal值的二进制表示形式、由四个元素组成的 32 位有符号整数数组</returns>
        //public static int TryGetBits(this decimal d, Span<int> destination)
        //{
        //    decimal.TryGetBits(d, destination, out int valuesWritten);

        //    return valuesWritten;
        //}

#endif

    }
}