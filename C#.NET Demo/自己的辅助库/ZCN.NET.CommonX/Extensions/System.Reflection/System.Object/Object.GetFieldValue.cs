using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回给定对象支持的字段的值。
        ///  如找到，则为表示具有指定名称的公共字段的 System.Reflection.FieldInfo 对象；否则为 null
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="fieldName">要获取的数据字段的名称</param>
        /// <returns>包含此实例反映的字段值的对象</returns>
        public static object GetFieldValue<T>(this T @this,string fieldName)
        {
            Type type = @this.GetType();
            FieldInfo field = type.GetField(fieldName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

            return field.GetValue(@this);
        }
    }
}