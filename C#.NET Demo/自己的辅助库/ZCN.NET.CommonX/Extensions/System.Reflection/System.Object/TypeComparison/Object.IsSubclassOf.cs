using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：确定当前 System.Type 表示的类是否是从指定的 System.Type 表示的类派生的
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="type">与当前的 Type 进行比较的 Type</param>
        /// <returns></returns>
        public static bool IsSubclassOf<T>(this T @this, Type type)
        {
            return @this.GetType().IsSubclassOf(type);
        }
    }
}