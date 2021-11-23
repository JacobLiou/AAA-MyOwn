using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回当前 System.Type 的所有公共方法。
        ///  返回为当前 System.Type 定义的所有公共方法的 System.Reflection.MethodInfo 对象数组。
        ///  如果没有为当前 System.Type 定义的公共方法，则为 System.Reflection.MethodInfo 类型的空数组
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static MethodInfo[] GetMethods<T>(this T @this)
        {
            return @this.GetType().GetMethods();
        }

        /// <summary>
        ///  自定义扩展方法：返回当前 System.Type 的所有公共方法。
        ///  返回为当前 System.Type 定义的所有公共方法的 System.Reflection.MethodInfo 对象数组。
        ///  如果没有为当前 System.Type 定义的公共方法，则为 System.Reflection.MethodInfo 类型的空数组
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="bindingAttr">一个位屏蔽，由一个或多个指定搜索执行方式的 System.Reflection.BindingFlags 组成。
        ///  或零，以返回 null</param>
        /// <returns></returns>
        public static MethodInfo[] GetMethods<T>(this T @this, BindingFlags bindingAttr)
        {
            return @this.GetType().GetMethods(bindingAttr);
        }
    }
}