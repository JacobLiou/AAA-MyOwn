using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断是否 attributeType 的一个或多个实例应用于此成员
        /// </summary>
        /// <param name="element">扩展对象</param>
        /// <param name="attributeType">自定义特性应用于的 Type 对象</param>
        /// <returns></returns>
        public static bool IsDefined(this Assembly element, Type attributeType)
        {
            return Attribute.IsDefined(element, attributeType);
        }

        /// <summary>
        ///  自定义扩展方法：确定是否将任意自定义特性应用于程序集。参数指定程序集、要搜索的自定义特性的类型以及忽略的搜索选项
        /// </summary>
        /// <param name="element">扩展对象</param>
        /// <param name="attributeType">要搜索的自定义特性的类型或基类型</param>
        /// <param name="inherit">指定是否搜索该成员的继承链以查找这些特性</param>
        /// <returns></returns>
        public static bool IsDefined(this Assembly element, Type attributeType, bool inherit)
        {
            return Attribute.IsDefined(element, attributeType, inherit);
        }
    }
}