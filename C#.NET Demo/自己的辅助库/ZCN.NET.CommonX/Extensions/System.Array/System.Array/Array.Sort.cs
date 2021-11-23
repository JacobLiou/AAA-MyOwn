using System;
using System.Collections;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：对整个一维 System.Array 数组中的元素进行排序
        /// </summary>
        /// <param name="array">要排序的一维 System.Array 数组</param>
        public static void Sort(this Array array)
        {
            Array.Sort(array);
        }

        /// <summary>
        /// 自定义扩展方法：基于第一个 System.Array 中的关键字，使用每个关键字的 System.IComparable 实现，
        /// 对两个一维 System.Array 对象（一个包含关键字，另一个包含对应的项）进行排序
        /// </summary>
        /// <param name="array">一维 System.Array，它包含要排序的关键字</param>
        /// <param name="items"> 一维 System.Array，它包含与 keysSystem.Array 中的每一个关键字对应的项。
        ///  如果为 null，则只对 keysSystem.Array进行排序
        /// </param>
        public static void Sort(this Array array,Array items)
        {
            Array.Sort(array,items);
        }

        /// <summary>
        /// 自定义扩展方法：对一维 System.Array 数组中某部分元素进行排序
        /// </summary>
        /// <param name="array">要排序的一维 System.Array 数组</param>
        /// <param name="index">排序范围的起始索引</param>
        /// <param name="length">排序范围内的元素数</param>
        public static void Sort(this Array array,Int32 index,Int32 length)
        {
            Array.Sort(array,index,length);
        }

        /// <summary>
        /// 自定义扩展方法：基于第一个 System.Array 中的关键字，使用每个关键字的 System.IComparable 实现，
        /// 对两个一维 System.Array 对象（一个包含关键字，另一个包含对应的项）的部分元素进行排序
        /// </summary>
        /// <param name="array">一维 System.Array，它包含要排序的关键字</param>
        /// <param name="items"> 一维 System.Array，它包含与 keysSystem.Array 中的每一个关键字对应的项。
        ///  如果为 null，则只对 keysSystem.Array进行排序
        /// </param>
        /// <param name="index">排序范围的起始索引</param>
        /// <param name="length">排序范围内的元素数</param>
        public static void Sort(this Array array,Array items,Int32 index,Int32 length)
        {
            Array.Sort(array,items,index,length);
        }

        /// <summary>
        /// 自定义扩展方法：将指定 System.Collections.IComparer，对一维 System.Array 数组中的元素进行排序
        /// </summary>
        /// <param name="array">要排序的一维 System.Array 数组</param>
        /// <param name="comparer">比较元素时要使用的 System.Collections.IComparer 实现。
        /// 如果为 null，则使用每个元素的 System.IComparable 实现</param>
        public static void Sort(this Array array,IComparer comparer)
        {
            Array.Sort(array,comparer);
        }

        /// <summary>
        /// 自定义扩展方法：基于第一个 System.Array 中的关键字，将指定 System.Collections.IComparer，
        /// 对两个一维 System.Array对象（一个包含关键字，另一个包含对应的项）进行排序
        /// </summary>
        /// <param name="array">要排序的一维 System.Array 数组</param>
        /// <param name="items"> 一维 System.Array，它包含与 keysSystem.Array 中的每一个关键字对应的项。
        ///  如果为 null，则只对 keysSystem.Array进行排序
        /// </param>
        /// <param name="comparer">比较元素时要使用的 System.Collections.IComparer 实现。
        /// 如果为 null，则使用每个元素的 System.IComparable 实现</param>
        public static void Sort(this Array array,Array items,IComparer comparer)
        {
            Array.Sort(array,items,comparer);
        }

        /// <summary>
        /// 自定义扩展方法：对一维 System.Array 的部分元素进行排序
        /// </summary>
        /// <param name="array">要排序的一维 System.Array 数组</param>
        /// <param name="index">排序范围的起始索引</param>
        /// <param name="length">排序范围内的元素数</param>
        /// <param name="comparer">比较元素时要使用的 System.Collections.IComparer 实现。
        /// 如果为 null，则使用每个元素的 System.IComparable 实现</param>
        public static void Sort(this Array array,Int32 index,Int32 length,IComparer comparer)
        {
            Array.Sort(array,index,length,comparer);
        }

        /// <summary>
        /// 自定义扩展方法： 基于第一个 System.Array 中的关键字，将指定 System.Collections.IComparer，
        /// 对两个一维 System.Array 对象（一个包含关键字，另一个包含对应的项）的部分元素进行排序
        /// </summary>
        /// <param name="array">要排序的一维 System.Array 数组</param>
        /// <param name="items"> 一维 System.Array，它包含与 keysSystem.Array 中的每一个关键字对应的项。
        ///  如果为 null，则只对 keysSystem.Array进行排序
        /// </param>
        /// <param name="index">排序范围的起始索引</param>
        /// <param name="length">排序范围内的元素数</param>
        /// <param name="comparer">比较元素时要使用的 System.Collections.IComparer 实现。
        /// 如果为 null，则使用每个元素的 System.IComparable 实现</param>
        public static void Sort(this Array array,Array items,Int32 index,Int32 length,IComparer comparer)
        {
            Array.Sort(array,items,index,length,comparer);
        }
    }
}