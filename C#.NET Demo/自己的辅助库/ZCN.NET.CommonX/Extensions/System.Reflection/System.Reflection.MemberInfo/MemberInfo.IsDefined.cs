using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：确定是否将任意自定义特性应用于类型成员。参数指定成员和要搜索的自定义特性的类型
        /// </summary>
        /// <param name="element">一个从 System.Reflection.MemberInfo 类派生的对象，
        ///  该类描述类的构造函数、事件、字段、方法、类型或属性成员
        /// </param>
        /// <param name="attributeType">要搜索的自定义特性的类型或基类型</param>
        /// <returns></returns>
        public static bool IsDefined(this MemberInfo element,Type attributeType)
        {
            return Attribute.IsDefined(element,attributeType);
        }

        /// <summary>
        ///  自定义扩展方法：确定是否将任意自定义特性应用于类型成员。参数指定成员、要搜索的自定义特性的类型以及是否搜索成员的祖先
        /// </summary>
        /// <param name="element">一个从 System.Reflection.MemberInfo 类派生的对象，
        ///  该类描述类的构造函数、事件、字段、方法、类型或属性成员
        /// </param>
        /// <param name="attributeType">要搜索的自定义特性的类型或基类型</param>
        /// <param name="inherit">如果为 true，则指定还在 element 的祖先中搜索自定义特性</param>
        /// <returns></returns>
        public static bool IsDefined(this MemberInfo element,Type attributeType,bool inherit)
        {
            return Attribute.IsDefined(element,attributeType,inherit);
        }
    }
}