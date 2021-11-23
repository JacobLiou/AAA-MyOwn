using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 将数组中的一系列元素设置为零、false 或 null，具体取决于元素类型
        /// </summary>
        /// <param name="array">需要清除的一维数组</param>
        /// <param name="index">要清除的一系列元素的起始索引</param>
        /// <param name="length">要清除的元素数</param>
        public static void Clear(this Array array, int index, int length)
        {
            Array.Clear(array, index, length);
        }

        /// <summary>
        /// 自定义扩展方法： 将数组中的所有元素设置为零、false 或 null，具体取决于元素类型
        /// </summary>
        /// <param name="this">需要清除的一维数组</param>
        public static void ClearAll(this Array @this)
        {
            Array.Clear(@this,0,@this.Length);
        }
    }
}