using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：检索应用于方法参数的自定义特性的数组。参数指定方法参数。
        ///  返回一个 System.Attribute 数组，包含应用于 element 的自定义特性；如果不存在此类自定义特性，则为空数组
        /// </summary>
        /// <param name="element">扩展对象。
        /// 一个从 System.Reflection.ParameterInfo 类派生的对象，该类描述可移植的可执行文件
        /// </param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this ParameterInfo element)
        {
            return Attribute.GetCustomAttributes(element);
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于方法参数的自定义特性的数组。参数指定模块和要搜索的自定义特性的类型。
        ///  返回一个 System.Attribute 数组，包含应用于 element 的自定义特性；如果不存在此类自定义特性，则为空数组
        /// </summary>
        /// <param name="element">扩展对象。
        /// 一个从 System.Reflection.ParameterInfo 类派生的对象，该类描述可移植的可执行文件
        /// </param>
        /// <param name="attributeType">要搜索的自定义特性的类型或基类型</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this ParameterInfo element, Type attributeType)
        {
            return Attribute.GetCustomAttributes(element, attributeType);
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于方法参数的自定义特性的数组。参数指定模块和要搜索的自定义特性的类型。
        ///  返回一个 System.Attribute 数组，包含应用于 element 的自定义特性；如果不存在此类自定义特性，则为空数组
        /// </summary>
        /// <param name="element">扩展对象。
        /// 一个从 System.Reflection.ParameterInfo 类派生的对象，该类描述可移植的可执行文件
        /// </param>
        /// <param name="attributeType">要搜索的自定义特性的类型或基类型</param>
        /// <param name="inherit">此参数被忽略，并且不会影响此方法的操作</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this ParameterInfo element, Type attributeType, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, attributeType, inherit);
        }

        /// <summary>
        ///  自定义扩展方法：检索应用于方法参数的自定义特性的数组。参数指定方法参数。
        ///  返回一个 System.Attribute 数组，包含应用于 element 的自定义特性；如果不存在此类自定义特性，则为空数组
        /// </summary>
        /// <param name="element">扩展对象。
        /// 一个从 System.Reflection.ParameterInfo 类派生的对象，该类描述可移植的可执行文件
        /// </param>
        /// <param name="inherit">此参数被忽略，并且不会影响此方法的操作</param>
        /// <returns></returns>
        public static Attribute[] GetCustomAttributes(this ParameterInfo element, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, inherit);
        }
    }
}