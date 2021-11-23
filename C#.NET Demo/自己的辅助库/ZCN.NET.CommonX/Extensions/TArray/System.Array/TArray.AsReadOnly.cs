using System;
using System.Collections.ObjectModel;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回指定数组的只读包装
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="array">扩展对象。从零开始的一维数组</param>
        /// <returns></returns>
        public static ReadOnlyCollection<T> AsReadOnly<T>(this T[] array)
        {
            return Array.AsReadOnly(array);
        }
    }
}