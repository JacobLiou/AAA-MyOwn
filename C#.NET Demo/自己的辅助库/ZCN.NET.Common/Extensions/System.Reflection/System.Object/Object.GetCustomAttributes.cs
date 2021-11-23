using System;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的自定义特性。参数指定成员、要搜索的自定义特性的类型
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this object @this)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes()
                : type.GetCustomAttributes();
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的自定义特性。参数指定成员、要搜索的自定义特性的类型以及是否搜索成员的祖先
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static object[] GetCustomAttributes(this object @this,bool inherit)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes(inherit)
                : type.GetCustomAttributes(inherit);
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的自定义特性。参数指定成员、要搜索的自定义特性的类型
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static T[] GetCustomAttributes<T>(this object @this) where T : Attribute
        {
            var type = @this.GetType();

            return (T[])(type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes(typeof(T))
                : type.GetCustomAttributes(typeof(T)));
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的自定义特性。参数指定成员、要搜索的自定义特性的类型以及是否搜索成员的祖先
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static T[] GetCustomAttributes<T>(this object @this,bool inherit) where T : Attribute
        {
            var type = @this.GetType();

            return (T[])(type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes(typeof(T),inherit)
                : type.GetCustomAttributes(typeof(T),inherit));
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的自定义特性。参数指定成员、要搜索的自定义特性的类型
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static T[] GetCustomAttributes<T>(this MemberInfo @this) where T : Attribute
        {
            return (T[])@this.GetCustomAttributes(typeof(T));
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的自定义特性。参数指定成员、要搜索的自定义特性的类型以及是否搜索成员的祖先
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static T[] GetCustomAttributes<T>(this MemberInfo @this,bool inherit) where T : Attribute
        {
            return (T[])@this.GetCustomAttributes(typeof(T),inherit);
        }
    }
}