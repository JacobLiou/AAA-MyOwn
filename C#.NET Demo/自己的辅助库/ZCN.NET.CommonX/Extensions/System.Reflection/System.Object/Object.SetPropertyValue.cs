using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：用索引属性的可选索引值设置该属性的值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="propertyName">属性名称</param>
        /// <param name="value">分配给属性的值</param>
        /// <returns></returns>
        public static void SetPropertyValue<T>(this T @this, string propertyName, object value)
        {
            Type type = @this.GetType();
            PropertyInfo property = type.GetProperty(propertyName,
                BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Static);
            property.SetValue(@this, value, null);
        }
    }
}