using System;
using System.Collections;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 在Array数组中搜索特定元素。
        /// 如果找到 value，则为指定 array 中的指定 value 的索引。
        /// 如果找不到 value 且 value 小于 array 中的一个或多个元素，则为一个负数，该负数是大于value 的第一个元素的索引的按位求补。
        /// 如果找不到 value 且 value 大于 array 中的任何元素，则为一个负数，该负数是（最后一个元素的索引加1）的按位求补
        /// </summary>
        /// <param name="array">要搜索的已排序一维 System.Array</param>
        /// <param name="value">要搜索的对象</param>
        /// <returns></returns>
        public static int BinarySearch(this Array array,object value)
        {
            return Array.BinarySearch(array,value);
        }

        /// <summary>
        /// 自定义扩展方法： 在Array数组中搜索特定元素。
        /// 如果找到 value，则为指定 array 中的指定 value 的索引。
        /// 如果找不到 value 且 value 小于 array 中的一个或多个元素，则为一个负数，该负数是大于value 的第一个元素的索引的按位求补。
        /// 如果找不到 value 且 value 大于 array 中的任何元素，则为一个负数，该负数是（最后一个元素的索引加1）的按位求补
        /// </summary>
        /// <param name="array">要搜索的已排序一维数组</param>
        /// <param name="index">要搜索的范围的起始索引</param>
        /// <param name="length">要搜索的范围的长度</param>
        /// <param name="value">要搜索的对象</param>
        /// <returns></returns>
        public static int BinarySearch(this Array array,int index,int length,object value)
        {
            return Array.BinarySearch(array,index,length,value);
        }

        /// <summary>
        /// 自定义扩展方法： 在Array数组中搜索特定元素。
        /// 如果找到 value，则为指定 array 中的指定 value 的索引。
        /// 如果找不到 value 且 value 小于 array 中的一个或多个元素，则为一个负数，该负数是大于value 的第一个元素的索引的按位求补。
        /// 如果找不到 value 且 value 大于 array 中的任何元素，则为一个负数，该负数是（最后一个元素的索引加1）的按位求补
        /// </summary>
        /// <param name="array">要搜索的已排序一维数组</param>
        /// <param name="value">要搜索的对象</param>
        /// <param name="comparer">比较元素时要使用的 System.Collections.IComparer 实现。
        ///                        如果为 null，则使用每个元素的 System.IComparable实现
        /// </param>
        /// <returns></returns>
        public static int BinarySearch(this Array array,object value,IComparer comparer)
        {
            return Array.BinarySearch(array,value,comparer);
        }

        /// <summary>
        /// 自定义扩展方法： 在Array数组中搜索特定元素。
        /// 如果找到 value，则为指定 array 中的指定 value 的索引。
        /// 如果找不到 value 且 value 小于 array 中的一个或多个元素，则为一个负数，该负数是大于value 的第一个元素的索引的按位求补。
        /// 如果找不到 value 且 value 大于 array 中的任何元素，则为一个负数，该负数是（最后一个元素的索引加1）的按位求补
        /// </summary>
        /// <param name="array">要搜索的已排序一维数组</param>
        /// <param name="index">要搜索的范围的起始索引</param>
        /// <param name="length">要搜索的范围的长度</param>
        /// <param name="value">要搜索的对象</param>
        /// <param name="comparer">比较元素时要使用的 System.Collections.IComparer 实现。
        ///                        如果为 null，则使用每个元素的 System.IComparable实现
        /// </param>
        /// <returns></returns>
        public static int BinarySearch(this Array array,int index,int length,object value,IComparer comparer)
        {
            return Array.BinarySearch(array,index,length,value,comparer);
        }
    }
}