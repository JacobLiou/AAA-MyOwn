using System;

namespace ZCN.NET.Common.Extensions
{
    /// <summary>
    /// 自定义扩展类
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///  自定义扩展方法：从指定索引处开始指定数量的元素设置为零、false 或 null，具体取决于元素类型
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象。从零开始的一维数组</param>
        /// <param name="index">要清除的一系列元素的起始索引</param>
        /// <param name="length">要清除的元素数</param>
        public static void ClearAt<T>(this T[] @this,int index,int length)
        {
            Array.Clear(@this,index,length);
        }
    }
}