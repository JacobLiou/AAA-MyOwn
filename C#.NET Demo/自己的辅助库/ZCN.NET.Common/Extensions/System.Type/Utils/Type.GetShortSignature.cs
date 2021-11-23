using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取.NET类型对应的字符串签名(例如bool类型对应"bool")
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        internal static string GetShortSignature(this Type @this)
        {
            if(@this == typeof (bool))
            {
                return "bool";
            }
            if(@this == typeof (byte))
            {
                return "byte";
            }
            if(@this == typeof (char))
            {
                return "char";
            }
            if(@this == typeof (decimal))
            {
                return "decimal";
            }
            if(@this == typeof (double))
            {
                return "double";
            }
            if(@this == typeof (Enum))
            {
                return "enum";
            }
            if(@this == typeof (float))
            {
                return "float";
            }
            if(@this == typeof (int))
            {
                return "int";
            }
            if(@this == typeof (long))
            {
                return "long";
            }
            if(@this == typeof (object))
            {
                return "object";
            }
            if(@this == typeof (sbyte))
            {
                return "sbyte";
            }
            if(@this == typeof (short))
            {
                return "short";
            }
            if(@this == typeof (string))
            {
                return "string";
            }
            if(@this == typeof (uint))
            {
                return "uint";
            }
            if(@this == typeof (ulong))
            {
                return "ulong";
            }
            if(@this == typeof (ushort))
            {
                return "ushort";
            }

            return @this.Name;
        }
    }
}