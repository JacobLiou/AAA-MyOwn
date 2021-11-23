using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 搜索指定的对象，并返回整个一维 System.Array 数组中最后一个匹配项的索引
        /// </summary>
        /// <param name="array">要搜索的一维 System.Array 数组</param>
        /// <param name="value">要在 array 数组中查找的对象</param>
        /// <returns></returns>
        public static int LastIndexOf(this Array array,object value)
        {
            return Array.LastIndexOf(array,value);
        }

        /// <summary>
        /// 自定义扩展方法：搜索指定的对象，并返回一维 System.Array 数组中从第一个元素到指定索引这部分元素中最后一个匹配项的索引 
        /// </summary>
        /// <param name="array">要搜索的一维 System.Array 数组</param>
        /// <param name="value">要在 array 数组中查找的对象</param>
        /// <param name="startIndex">搜索的起始索引。空数组中 0（零）为有效值</param>
        /// <returns></returns>
        public static int LastIndexOf(this Array array,object value,int startIndex)
        {
            return Array.LastIndexOf(array,value,startIndex);
        }

        /// <summary>
        /// 自定义扩展方法： 搜索指定的对象，并返回一维 System.Array 数组中到指定索引为止包含指定个元素的这部分元素中最后一个匹配项的索引
        /// </summary>
        /// <param name="array">要搜索的一维 System.Array 数组</param>
        /// <param name="value">要在 array 数组中查找的对象</param>
        /// <param name="startIndex">搜索的起始索引。空数组中 0（零）为有效值</param>
        /// <param name="count">要搜索的部分中的元素数</param>
        /// <returns></returns>
        public static int LastIndexOf(this Array array,object value,int startIndex,int count)
        {
            return Array.LastIndexOf(array,value,startIndex,count);
        }
    }
}