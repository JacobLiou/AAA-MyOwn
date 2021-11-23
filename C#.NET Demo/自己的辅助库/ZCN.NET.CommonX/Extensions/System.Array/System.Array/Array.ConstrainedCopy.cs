using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法： 从指定的源索引开始，复制 System.Array 数组中的一系列元素，
        ///  将它们粘贴到另一 System.Array 数组中（从指定的目标索引开始）。
        ///  保证在复制未成功完成的情况下撤消所有更改
        /// </summary>
        /// <param name="sourceArray">源数组</param>
        /// <param name="sourceIndex">表示源数组中复制开始处的索引</param>
        /// <param name="destinationArray">目标数组</param>
        /// <param name="destinationIndex">表示目标数组中存储开始处的索引</param>
        /// <param name="length">它表示要复制的元素数目</param>
        public static void ConstrainedCopy(this Array sourceArray,
            int sourceIndex,
            Array destinationArray,
            int destinationIndex,
            int length)
        {
            Array.ConstrainedCopy(sourceArray,sourceIndex,destinationArray,destinationIndex,length);
        }
    }
}