using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从一个委托的调用列表中移除另一个委托的最后一个调用列表。
        ///  返回一个新委托，其调用列表的构成方法为：获取 source 的调用列表，
        ///  如果在 source 的调用列表中找到了 value 的调用列表，则从中移除 value 的最后一个调用列表。 
        ///  如果 value 为 null，或在 source 的调用列表中没有找到 value 的调用列表，则返回 source。
        ///  如果 value 的调用列表等于 source 的调用列表，或 source 为空引用，则返回空引用
        /// </summary>
        /// <param name="source">扩展对象。委托，将从中移除 value 的调用列表</param>
        /// <param name="value">委托，它提供将从其中移除 source 的调用列表的调用列表</param>
        /// <returns></returns>
        public static Delegate Remove(this Delegate source,Delegate value)
        {
            return Delegate.Remove(source,value);
        }
    }
}