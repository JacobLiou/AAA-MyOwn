using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回当前 System.Type 的所有公共字段。
        ///  如果没有为当前 System.Type 定义的公共字段，则为 System.Reflection.FieldInfo 类型的空数组
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static FieldInfo[] GetFields(this object @this)
        {
            return @this.GetType().GetFields();
        }

        /// <summary>
        ///  自定义扩展方法：使用指定绑定约束，搜索为当前 System.Type 定义的字段。
        ///  如果没有为当前 System.Type 定义的字段，或者如果没有一个定义的字段匹配绑定约束，则为 System.Reflection.FieldInfo 类型的空数组
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="bindingAttr"> 一个位屏蔽，由一个或多个指定搜索执行方式的 System.Reflection.BindingFlags 组成。
        ///  或零，以返回 null
        /// </param>
        /// <returns></returns>
        public static FieldInfo[] GetFields(this object @this, BindingFlags bindingAttr)
        {
            return @this.GetType().GetFields(bindingAttr);
        }
    }
}