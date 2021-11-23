using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：搜索具有指定名称的公共字段。
        ///  如找到，则为表示具有指定名称的公共字段的 System.Reflection.FieldInfo 对象；否则为 null
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="name">要获取的数据字段的名称</param>
        /// <returns></returns>
        public static FieldInfo GetField<T>(this T @this, string name)
        {
            return @this.GetType().GetField(name);
        }

        /// <summary>
        ///  自定义扩展方法：使用指定绑定约束搜索指定字段。
        ///  返回符合指定要求的字段的 System.Reflection.FieldInfo 对象（如果找到的话）；否则为 null
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="name">要获取的数据字段的名称</param>
        /// <param name="bindingAttr">一个位屏蔽，由一个或多个指定搜索执行方式的 System.Reflection.BindingFlags 组成。
        ///  或 零，以返回 null</param>
        /// <returns></returns>
        public static FieldInfo GetField<T>(this T @this, string name, BindingFlags bindingAttr)
        {
            return @this.GetType().GetField(name, bindingAttr);
        }
    }
}