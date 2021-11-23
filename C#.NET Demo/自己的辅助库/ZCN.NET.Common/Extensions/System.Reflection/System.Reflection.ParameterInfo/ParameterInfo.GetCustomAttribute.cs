using System;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：检索应用于方法参数的自定义特性。参数指定方法参数和要搜索的自定义特性的类型。
        ///  返回一个引用，指向应用于 element 的 attributeType 类型的单个自定义特性；如果没有此类特性，则为 null
        /// </summary>
        /// <param name="element">扩展对象。
        /// 一个从 System.Reflection.ParameterInfo 类派生的对象，该类描述类成员的参数</param>
        /// <param name="attributeType">要搜索的自定义特性的类型或基类型</param>
        /// <returns></returns>
        public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType)
        {
            return Attribute.GetCustomAttribute(element, attributeType);
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于方法参数的自定义特性。参数指定模块、要搜索的自定义特性的类型以及忽略的搜索选项。
        ///  返回一个引用，指向应用于 element 的 attributeType 类型的单个自定义特性；如果没有此类特性，则为 null
        /// </summary>
        /// <param name="element">扩展对象。
        ///  一个从 System.Reflection.ParameterInfo 类派生的对象，该类描述类成员的参数</param>
        /// <param name="attributeType">要搜索的自定义特性的类型或基类型</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType, Boolean inherit)
        {
            return Attribute.GetCustomAttribute(element, attributeType, inherit);
        }
    }
}