using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法： 搜索具有指定名称的公共方法。
        ///  返回具有指定名称的公共方法的 System.Reflection.MethodInfo 对象（如果找到的话）；否则为 null
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="name">要获取的公共方法的名称</param>
        /// <returns>
        ///   表示具有指定名称的公共方法的 System.Reflection.MethodInfo 对象（如果找到的话）；否则为 null
        /// </returns>
        public static MethodInfo GetMethod<T>(this T @this, string name)
        {
            return @this.GetType().GetMethod(name);
        }

        /// <summary>
        ///  自定义扩展方法： 使用指定绑定约束搜索指定方法。
        ///  返回具有指定名称的公共方法的 System.Reflection.MethodInfo 对象（如果找到的话）；否则为 null
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="name">要获取的公共方法的名称</param>
        /// <param name="bindingAttr">一个位屏蔽，由一个或多个指定搜索执行方式的 System.Reflection.BindingFlags 组成。
        ///  或 零，以返回 null
        /// </param>
        /// <returns></returns>
        public static MethodInfo GetMethod<T>(this T @this, string name, BindingFlags bindingAttr)
        {
            return @this.GetType().GetMethod(name, bindingAttr);
        }
    }
}