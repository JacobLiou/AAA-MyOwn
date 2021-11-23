using System;

namespace ZCN.NET.CommonX.Extensions
{
    /// <summary>
    /// 自定义扩展类
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///  自定义扩展方法：将 System.Array 中的一系列元素设置为零、false 或 null，具体取决于元素类型
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象。从零开始的一维数组</param>
        /// <returns></returns>
        public static void ClearAll<T>(this T[] @this)
        {
            Array.Clear(@this, 0, @this.Length);
        }
    }
}