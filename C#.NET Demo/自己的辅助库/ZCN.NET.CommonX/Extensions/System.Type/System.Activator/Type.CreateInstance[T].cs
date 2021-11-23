using System;
using System.Globalization;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：使用与指定参数匹配程度最高的构造函数创建指定类型的实例
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象。要创建的对象的类型</param>
        /// <param name="bindingAttr">影响 type 构造函数搜索的零个或多个位标志的组合。
        ///  如果 bindingAttr 为零，则对公共构造函数进行区分大小写的搜索
        /// </param>
        /// <param name="binder"> 使用 bindingAttr 和 args 来查找和标识 type 构造函数的对象。
        ///  如果 binder 为 null，则使用默认联编程序
        /// </param>
        /// <param name="args">与要调用构造函数的参数数量、顺序和类型匹配的参数数组。
        ///  如果 args 为空数组或 null，则调用不带任何参数的构造函数（默认构造函数）
        /// </param>
        /// <param name="culture">区域性特定的信息，这些信息控制将 args 强制转换为 type 构造函数所声明的正式类型。
        ///  如果 culture 为 null，则使用当前线程的 System.Globalization.CultureInfo
        /// </param>
        /// <returns>对新创建对象的引用</returns>
        public static T CreateInstance<T>(this Type @this,
            BindingFlags bindingAttr,
            Binder binder,
            Object[] args,
            CultureInfo culture)
        {
            return (T) Activator.CreateInstance(@this, bindingAttr, binder, args, culture);
        }

        /// <summary>
        ///  自定义扩展方法：使用与指定参数匹配程度最高的构造函数创建指定类型的实例
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象。要创建的对象的类型</param>
        /// <param name="bindingAttr">影响 type 构造函数搜索的零个或多个位标志的组合。
        ///  如果 bindingAttr 为零，则对公共构造函数进行区分大小写的搜索
        /// </param>
        /// <param name="binder"> 使用 bindingAttr 和 args 来查找和标识 type 构造函数的对象。
        ///  如果 binder 为 null，则使用默认联编程序
        /// </param>
        /// <param name="args">与要调用构造函数的参数数量、顺序和类型匹配的参数数组。
        ///  如果 args 为空数组或 null，则调用不带任何参数的构造函数（默认构造函数）
        /// </param>
        /// <param name="culture">区域性特定的信息，这些信息控制将 args 强制转换为 type 构造函数所声明的正式类型。
        ///  如果 culture 为 null，则使用当前线程的 System.Globalization.CultureInfo
        /// </param>
        /// <param name="activationAttributes">包含一个或多个可以参与激活的特性的数组。
        ///  通常为包含单个 System.Runtime.Remoting.Activation.UrlAttribute 对象的数组
        /// </param>
        /// <returns>对新创建对象的引用</returns>
        public static T CreateInstance<T>(this Type @this,
            BindingFlags bindingAttr,
            Binder binder,
            Object[] args,
            CultureInfo culture,
            Object[] activationAttributes)
        {
            return (T) Activator.CreateInstance(@this, bindingAttr, binder, args, culture, activationAttributes);
        }

        /// <summary>
        ///  自定义扩展方法：使用与指定参数匹配程度最高的构造函数创建指定类型的实例
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象。要创建的对象的类型</param>
        /// <param name="args">与要调用构造函数的参数数量、顺序和类型匹配的参数数组。
        ///  如果 args 为空数组或 null，则调用不带任何参数的构造函数（默认构造函数）
        /// </param>
        /// <returns>对新创建对象的引用</returns>
        public static T CreateInstance<T>(this Type @this, Object[] args)
        {
            return (T) Activator.CreateInstance(@this, args);
        }

        /// <summary>
        ///  自定义扩展方法：使用与指定参数匹配程度最高的构造函数创建指定类型的实例
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象。要创建的对象的类型</param>
        /// <param name="args">与要调用构造函数的参数数量、顺序和类型匹配的参数数组。
        ///  如果 args 为空数组或 null，则调用不带任何参数的构造函数（默认构造函数）
        /// </param>
        /// <param name="activationAttributes">包含一个或多个可以参与激活的特性的数组。
        ///  通常为包含单个 System.Runtime.Remoting.Activation.UrlAttribute 对象的数组
        /// </param>
        /// <returns>对新创建对象的引用</returns>
        public static T CreateInstance<T>(this Type @this, Object[] args, Object[] activationAttributes)
        {
            return (T) Activator.CreateInstance(@this, args, activationAttributes);
        }

        /// <summary>
        ///  自定义扩展方法：使用与指定参数匹配程度最高的构造函数创建指定类型的实例
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象。要创建的对象的类型</param>
        /// <returns>对新创建对象的引用</returns>
        public static T CreateInstance<T>(this Type @this)
        {
            return (T) Activator.CreateInstance(@this);
        }

        /// <summary>
        ///  自定义扩展方法：使用与指定参数匹配程度最高的构造函数创建指定类型的实例
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象。要创建的对象的类型</param>
        /// <param name="nonPublic">如果公共或非公共默认构造函数可以匹配，则为 true；如果只有公共默认构造函数可以匹配，则为 false</param>
        /// <returns>对新创建对象的引用</returns>
        public static T CreateInstance<T>(this Type @this, Boolean nonPublic)
        {
            return (T) Activator.CreateInstance(@this, nonPublic);
        }
    }
}