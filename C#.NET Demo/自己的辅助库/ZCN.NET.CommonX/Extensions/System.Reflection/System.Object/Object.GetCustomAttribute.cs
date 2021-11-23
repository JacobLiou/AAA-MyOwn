using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的第一个自定义特性。参数指定成员、要搜索的自定义特性的类型
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="attribute">要搜索的自定义特性的类型或基类型</param>
        /// <returns></returns>
        public static object GetCustomAttribute(this object @this, Type attribute)
        {
            var type = @this.GetType();

            return type.IsEnum
                       ? Attribute.GetCustomAttribute(type.GetField(@this.ToString()), attribute)
                       : Attribute.GetCustomAttribute(type, attribute);
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的第一个自定义特性。参数指定成员、要搜索的自定义特性的类型以及是否搜索成员的祖先
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="attribute">要搜索的自定义特性的类型或基类型</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static object GetCustomAttribute(this object @this, Type attribute, bool inherit)
        {
            var type = @this.GetType();

            return type.IsEnum
                       ? Attribute.GetCustomAttribute(type.GetField(@this.ToString()), attribute, inherit)
                       : Attribute.GetCustomAttribute(type, attribute, inherit);
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的第一个自定义特性。参数指定成员、要搜索的自定义特性的类型
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static T GetCustomAttribute<T>(this object @this) where T : Attribute
        {
            var type = @this.GetType();

            return (T) (type.IsEnum
                            ? Attribute.GetCustomAttribute(type.GetField(@this.ToString()), typeof(T))
                            : Attribute.GetCustomAttribute(type, typeof(T)));
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的第一个自定义特性。参数指定成员、要搜索的自定义特性的类型以及是否搜索成员的祖先
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static T GetCustomAttribute<T>(this object @this, bool inherit) where T : Attribute
        {
            var type = @this.GetType();

            return (T) (type.IsEnum
                            ? Attribute.GetCustomAttribute(type.GetField(@this.ToString()), typeof(T), inherit)
                            : Attribute.GetCustomAttribute(type, typeof(T), inherit));
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的第一个自定义特性。参数指定成员、要搜索的自定义特性的类型
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static T GetCustomAttribute<T>(this MemberInfo @this) where T : Attribute
        {
            return (T) Attribute.GetCustomAttribute(@this, typeof(T));
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的第一个自定义特性。参数指定成员、要搜索的自定义特性的类型以及是否搜索成员的祖先
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static T GetCustomAttribute<T>(this MemberInfo @this, bool inherit) where T : Attribute
        {
            return (T) Attribute.GetCustomAttribute(@this, typeof(T), inherit);
        }
    }
}