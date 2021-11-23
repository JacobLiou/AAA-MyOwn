using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回当前 System.Type 的所有公共属性。
        ///  返回当前 System.Type 的所有公共属性的 System.Reflection.PropertyInfo 对象数组。
        ///  如果当前 System.Type 没有公共属性，则为 System.Reflection.PropertyInfo 类型的空数组
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static PropertyInfo[] GetProperties(this object @this)
        {
            return @this.GetType().GetProperties();
        }

        /// <summary>
        ///  自定义扩展方法：返回当前 System.Type 的所有公共属性。
        ///  返回当前 System.Type 的所有公共属性的 System.Reflection.PropertyInfo 对象数组。
        ///  如果当前 System.Type 没有公共属性，则为 System.Reflection.PropertyInfo 类型的空数组
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="bindingAttr">一个位屏蔽，由一个或多个指定搜索执行方式的 System.Reflection.BindingFlags 组成。
        ///  或零，以返回 null</param>
        /// <returns></returns>
        public static PropertyInfo[] GetProperties(this object @this, BindingFlags bindingAttr)
        {
            return @this.GetType().GetProperties(bindingAttr);
        }
    }
}