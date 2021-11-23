using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：判断当前 System.Type 表示的类型与指定的类型是否相等
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="type">与当前的 Type 进行比较的 Type</param>
        /// <returns></returns>
        public static bool IsTypeOf<T>(this T @this, Type type)
        {
            return @this.GetType() == type;
        }
    }
}