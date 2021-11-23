using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region IsAssignableFrom

        /// <summary>
        ///  自定义扩展方法：判断扩展对象的实例是否可以从指定 T 类型的实例分配
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsAssignableFrom<T>(this object @this)
        {
            Type type = @this.GetType();
            return type.IsAssignableFrom(typeof(T));
        }

        /// <summary>
        ///  自定义扩展方法：判断扩展对象的实例是否可以从指定 Type 类型的实例分配
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="targetType">目标类型</param>
        /// <returns></returns>
        public static bool IsAssignableFrom(this object @this, Type targetType)
        {
            Type type = @this.GetType();
            return type.IsAssignableFrom(targetType);
        }

        #endregion
    }
}
