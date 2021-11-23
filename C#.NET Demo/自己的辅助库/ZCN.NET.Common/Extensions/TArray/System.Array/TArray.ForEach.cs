using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：对指定数组的每个元素执行指定操作
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="array">扩展对象。从零开始的一维数组</param>
        /// <param name="action">要对 array 的每个元素执行的方法</param>
        public static void ForEach<T>(this T[] array, Action<T> action)
        {
            Array.ForEach(array, action);
        }
    }
}