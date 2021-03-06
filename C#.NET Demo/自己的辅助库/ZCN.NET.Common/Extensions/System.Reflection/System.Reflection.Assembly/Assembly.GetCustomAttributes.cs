using System;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的自定义特性。参数指定成员、要搜索的自定义特性的类型
        /// </summary>
        /// <param name="element">扩展对象</param>
        /// <param name="attributeType">要搜索的自定义特性的类型或基类型</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this Assembly element, Type attributeType)
        {
            return Attribute.GetCustomAttributes(element, attributeType);
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的自定义特性。参数指定成员、要搜索的自定义特性的类型以及是否搜索成员的祖先
        /// </summary>
        /// <param name="element">扩展对象</param>
        /// <param name="attributeType">要搜索的自定义特性的类型或基类型</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this Assembly element, Type attributeType, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, attributeType, inherit);
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的自定义特性。参数指定成员、要搜索的自定义特性的类型
        /// </summary>
        /// <param name="element">扩展对象</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this Assembly element)
        {
            return Attribute.GetCustomAttributes(element);
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型成员的自定义特性。参数指定成员、要搜索的自定义特性的类型以及是否搜索成员的祖先
        /// </summary>
        /// <param name="element">扩展对象</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this Assembly element, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, inherit);
        }
    }
}