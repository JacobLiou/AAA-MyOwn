using System;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：检索应用于类型的成员的自定义特性的数组。参数指定成员和要搜索的自定义特性的类型
        /// </summary>
        /// <param name="element">扩展对象。
        ///  一个从 System.Reflection.MemberInfo 类派生的对象，该类描述类的构造函数、事件、字段、方法或属性成员
        /// </param>
        /// <param name="type">要搜索的自定义特性的类型或基类型</param>
        /// <returns>一个 System.Attribute 数组，包含应用于 element 的 type 类型的自定义特性；
        ///          如果不存在此类自定义特性，则为空数组
        /// </returns>
        public static Attribute[] GetCustomAttributes(this MemberInfo element,Type type)
        {
            return Attribute.GetCustomAttributes(element,type);
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型的成员的自定义特性的数组。参数指定成员、要搜索的自定义特性的类型以及是否搜索成员的祖先
        /// </summary>
        /// <param name="element">扩展对象。
        ///  一个从 System.Reflection.MemberInfo 类派生的对象，该类描述类的构造函数、事件、字段、方法或属性成员
        /// </param>
        /// <param name="type">要搜索的自定义特性的类型或基类型</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this MemberInfo element,Type type,Boolean inherit)
        {
            return Attribute.GetCustomAttributes(element,type,inherit);
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型的成员的自定义特性的数组
        /// </summary>
        /// <param name="element">扩展对象。
        ///  一个从 System.Reflection.MemberInfo 类派生的对象，该类描述类的构造函数、事件、字段、方法或属性成员
        /// </param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this MemberInfo element)
        {
            return Attribute.GetCustomAttributes(element);
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于类型的成员的自定义特性的数组。参数指定成员、要搜索的自定义特性的类型以及是否搜索成员的祖先
        /// </summary>
        /// <param name="element">扩展对象。
        ///  一个从 System.Reflection.MemberInfo 类派生的对象，该类描述类的构造函数、事件、字段、方法或属性成员
        /// </param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this MemberInfo element,Boolean inherit)
        {
            return Attribute.GetCustomAttributes(element,inherit);
        }
    }
}