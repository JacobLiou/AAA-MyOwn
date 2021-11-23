using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：确定当前 System.Type 表示的类型与指定的类型是否相等；
        ///   或者是否是从指定的 System.Type 表示的类派生的
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="type">与当前的 Type 进行比较的 Type</param>
        /// <returns></returns>
        public static bool IsTypeOrInheritsOf<T>(this T @this, Type type)
        {
            Type objectType = @this.GetType();

            while (true)
            {
                if (objectType.Equals(type))
                    return true;

                if ((objectType == objectType.BaseType) || (objectType.BaseType == null))
                    return false;

                objectType = objectType.BaseType;
            }
        }
    }
}