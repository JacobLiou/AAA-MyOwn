using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：从第一个元素开始复制 System.Array 数组中的一系列元素，
        /// 将它们粘贴到另一 System.Array 数组中（从第一个元素开始）
        /// </summary>
        /// <param name="sourceArray">源数组</param>
        /// <param name="destinationArray">目标数组</param>
        /// <param name="length">表示要复制的元素数目(指定为32 位整数)</param>
        public static void Copy(this Array sourceArray,Array destinationArray,Int32 length)
        {
            Array.Copy(sourceArray,destinationArray,length);
        }

        /// <summary>
        /// 自定义扩展方法：从第一个元素开始复制 System.Array 数组中的一系列元素，
        /// 将它们粘贴到另一 System.Array 数组中（从第一个元素开始）
        /// </summary>
        /// <param name="sourceArray">源数组</param>
        /// <param name="sourceIndex">表示源数组中复制开始处的索引(指定为32 位整数)</param>
        /// <param name="destinationArray">目标数组</param>
        /// <param name="destinationIndex">表示目标数组中存储开始处的索引(指定为32 位整数)</param>
        /// <param name="length">它表示要复制的元素数目(指定为32 位整数)</param>
        public static void Copy(this Array sourceArray,
            int sourceIndex,
            Array destinationArray,
            int destinationIndex,
            int length)
        {
            Array.Copy(sourceArray,sourceIndex,destinationArray,destinationIndex,length);
        }

        /// <summary>
        /// 自定义扩展方法：从第一个元素开始复制 System.Array 数组中的一系列元素，
        /// 将它们粘贴到另一 System.Array 数组中（从第一个元素开始）
        /// </summary>
        /// <param name="sourceArray">源数组</param>
        /// <param name="destinationArray">目标数组</param>
        /// <param name="length">表示要复制的元素数目(指定为64 位整数)</param>
        public static void Copy(this Array sourceArray,Array destinationArray,Int64 length)
        {
            Array.Copy(sourceArray,destinationArray,length);
        }


        /// <summary>
        /// 自定义扩展方法：从第一个元素开始复制 System.Array 数组中的一系列元素，
        /// 将它们粘贴到另一 System.Array 数组中（从第一个元素开始）
        /// </summary>
        /// <param name="sourceArray">源数组</param>
        /// <param name="sourceIndex">表示源数组中复制开始处的索引(指定为64 位整数)</param>
        /// <param name="destinationArray">目标数组</param>
        /// <param name="destinationIndex">表示目标数组中存储开始处的索引(指定为64 位整数)</param>
        /// <param name="length">它表示要复制的元素数目(指定为64 位整数)</param>
        public static void Copy(this Array sourceArray,
            Int64 sourceIndex,
            Array destinationArray,
            Int64 destinationIndex,
            Int64 length)
        {
            Array.Copy(sourceArray,sourceIndex,destinationArray,destinationIndex,length);
        }
    }
}