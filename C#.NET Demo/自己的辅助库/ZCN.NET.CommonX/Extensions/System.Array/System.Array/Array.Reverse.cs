using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：反转整个一维 System.Array 数组中元素的顺序
        /// </summary>
        /// <param name="array">要反转的一维 System.Array 数组</param>
        public static void Reverse(this Array array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        /// 自定义扩展方法：反转一维 System.Array 中某部分元素的元素顺序
        /// </summary>
        /// <param name="array">要反转的一维 System.Array 数组</param>
        /// <param name="index">要反转的部分的起始索引</param>
        /// <param name="length">要反转的部分中的元素数</param>
        public static void Reverse(this Array array, int index, int length)
        {
            Array.Reverse(array, index, length);
        }
    }
}