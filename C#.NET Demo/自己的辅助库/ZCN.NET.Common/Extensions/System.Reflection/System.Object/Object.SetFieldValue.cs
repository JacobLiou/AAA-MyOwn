using System;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置给定对象支持的字段值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="fieldName">字段名称</param>
        /// <param name="value">分配给字段的值</param>
        /// <returns></returns>
        public static void SetFieldValue<T>(this T @this, string fieldName, object value)
        {
            Type type = @this.GetType();
            FieldInfo field = type.GetField(fieldName,
                BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Static);
            field.SetValue(@this, value);
        }
    }
}