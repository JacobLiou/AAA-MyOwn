using System;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：检索应用于模块的自定义特性。参数指定模块、要搜索的自定义特性的类型以及忽略的搜索选项。
        ///  返回一个引用，指向应用于 element 的 attributeType 类型的单个自定义特性；如果没有此类特性，则为 null
        /// </summary>
        /// <param name="element">扩展对象。
        /// 一个从 System.Reflection.Module 类派生的对象，该类描述可移植的可执行文件</param>
        /// <param name="attributeType">要搜索的自定义特性的类型或基类型</param>
        /// <returns></returns>
        public static Attribute GetCustomAttribute(this Module element,Type attributeType)
        {
            return Attribute.GetCustomAttribute(element,attributeType);
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于模块的自定义特性。参数指定模块、要搜索的自定义特性的类型以及忽略的搜索选项。
        ///  返回一个引用，指向应用于 element 的 attributeType 类型的单个自定义特性；如果没有此类特性，则为 null
        /// </summary>
        /// <param name="element">扩展对象。
        /// 一个从 System.Reflection.Module 类派生的对象，该类描述可移植的可执行文件</param>
        /// <param name="attributeType">要搜索的自定义特性的类型或基类型</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static Attribute GetCustomAttribute(this Module element,Type attributeType,bool inherit)
        {
            return Attribute.GetCustomAttribute(element,attributeType,inherit);
        }
    }
}